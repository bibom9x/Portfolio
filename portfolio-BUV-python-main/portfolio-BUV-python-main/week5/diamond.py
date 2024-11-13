def diamond(width):
    for i in range(width * 2):
        if i <= width:
            spaces = width - i
            stars = i
            print(" " * spaces + "* " * stars)
        else:
            spaces = i - width
            stars = 2*width - i
            print(" " * spaces + "* " * stars)

def main():
    width = int(input("Enter the width of the diamond: "))
    if width <= 2 or width >= 40:
        print("Invalid input")
        exit()
    else: 
        diamond(width)

if __name__ == "__main__":
    main()