def initials(name):
    full_name = name.split()
    initials = ""
    for i in range (len(full_name) - 1):
        s = full_name[i]
        initials += (s[0].upper()+'.') # s[0] is the first letter of the name
    initials += full_name[-1].title() # full_name[-1] is the last name
    return initials

def main():
    name = input("Enter your name: ")
    print(initials(name))

if __name__ == "__main__":
    main()