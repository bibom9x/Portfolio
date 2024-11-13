def initials(first, last):
    return first[0] + last[0]

def main():
    first = input("Enter your first name: ")
    last = input("Enter your last name: ")
    print(f"Your initials are {initials(first, last)}.")

main()