rainbow_colors = ['Red', 'Orange', 'Yellow', 'Green', 'Blue', 'Indigo', 'Violet']

def colors():
    color = int(input("Enter a number between 1 and 7: "))
    if color < 1 or color > 7:
        print("Invalid input.")
    else:
        print(rainbow_colors[color - 1])

if __name__ == "__main__":
    colors()