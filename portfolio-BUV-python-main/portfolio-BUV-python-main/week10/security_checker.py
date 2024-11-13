import json
import getpass
import hashlib
import os
import re


logins = open("passwords.json", "r")

new_login = {}

if os.stat("passwords.json").st_size == 0:
    existing_logins = {}
else:
    existing_logins = json.load(logins)

def check_password_strength(password):
    if len(password) < 8:
        print("Password must be at least 8 characters long")
        return False
    elif re.search(r"\s", password): 
        print("Password cannot contain spaces")
        return False
    elif password and password[0].isdigit():
        print("The first character cannot be a number")
        return False
    else:
        return True

def check_username(username):
    if username in existing_logins:
        return False
    else:
        return True

def hash_password(password):
    salt = os.urandom(32)
    key = hashlib.pbkdf2_hmac('sha256', password.encode('utf-8'), salt, 100000, dklen=128)
    storage = salt + key
    hex_storage = storage.hex()
    return hex_storage

def check_password(password, storage):
    storage = bytes.fromhex(storage)
    salt = storage[:32] # Get the salt from the storage
    key = storage[32:] # Get the key from the storage
    check_key = hashlib.pbkdf2_hmac('sha256', password.encode('utf-8'), salt, 100000, dklen=128)
    if check_key == key:
        return True
    else:
        return False

def new_users():
    new_user = input("Please enter a new username: ")
    new_passwd = getpass.getpass("Please enter a new password: ")
    repeat_passwd = getpass.getpass("Please repeat your password: ")
    if new_passwd != repeat_passwd:
        print("Passwords do not match")
        new_users()
    if check_password_strength(new_passwd):
        if check_username(new_user):
            b_password = hash_password(new_passwd)
            print(b_password)
            b_password = b_password  
            new_login[new_user] = b_password  # Add the new login to the dictionary
            existing_logins.update(new_login)
            with open("passwords.json", "w") as f:
                json.dump(existing_logins, f)  # Write the new login to the file
            print("New user created")
        else:
            print("Username already exists")
            new_users()
    else:
        new_users()

def existing_users():
    login_username = input("Please enter your username: ")
    login_password = getpass.getpass("Please enter your password: ")
    if check_username(login_username):
        print("Username does not exist")
    else:
        existing_hash = existing_logins[login_username]
        if check_password(login_password, existing_hash):  # Check if the password matches the hash
            print("Login successful")
            exit()
        else:
            print("Incorrect password")
            existing_users()

def main():
    print("Welcome to the login system")
    print("1. New User")
    print("2. Existing User")
    print("Type 'exit' to exit the program")
    choice = input("Please enter your choice: ")
    if choice == "1":
        new_users()
    elif choice == "2":
        existing_users()
    elif choice == "exit":
        exit()
    else:
        print("Invalid choice")
        main()

if __name__ == "__main__":
    main()