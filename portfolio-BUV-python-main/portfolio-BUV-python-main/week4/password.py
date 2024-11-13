 
def password(input):
    match input:
        case "thisismypassword":
            return True
        case default:
            return False
        


while True:
    passwd_input = input("Enter password: ")
    if password(passwd_input):
        print("Welcome")
        break
    else:
        print("Please try again")

    

