width = int(input("Enter the width of the grid: "))
height = int(input("Enter the height of the grid: "))

def grid(width, height):
    for i in range(width):
        for y in range(height):
            print("*", end=" ")
        print()

grid(width, height)