import random
dice_thrown = []
def throw_a_dice():
    dice = random.randint(1,6)
    dice_thrown.append(dice)
    return dice

def throw_until_doubles():
    while True:
        first = throw_a_dice()
        second = throw_a_dice()
        if first == second:
            return first, second
        else:
            continue

def main():
    print("Welcome to the dice throwing game!")
    print("You will throw two dice until you get doubles")
    print("The numbers you throw will be saved in a list")
    print("The program will stop when you get doubles")
    print("The numbers you throw are: ")
    first, second = throw_until_doubles()
    print(dice_thrown)
    print(f"You got doubles! The numbers were {first} and {second}")
    print("Thanks for playing!")

if __name__ == "__main__":
    main()
    