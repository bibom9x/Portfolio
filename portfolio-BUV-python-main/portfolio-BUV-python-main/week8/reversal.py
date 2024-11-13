def reverse_string(string):
    return string[::-1]

def main():
    string = input("Enter a string: ")
    print("Reversed string: ", reverse_string(string)) # Call the function

main()