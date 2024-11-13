import random 
import os
import platform

#TODO: add scoring system

card_dictionary = { 
    1: "Ace",
    11: "Jack",
    12: "Queen",
    13: "King"
}

random_number = []
def card_generation():
    for i in range(2): # generate 2 random number without repetition
        r = random.randint(1, 13)
        if r not in random_number:  
            random_number.append(r)

def dictionizer(num): # check if the number is in the dict and ret the value 
    if num in card_dictionary:
        return card_dictionary[num]
    else:
        return num

def higher_or_lower(input, first, second): 
    match input:
        case "higher":
            if first < second:
                return True
            else:
                return False
        case "lower":
            if first > second:
                return True
            else:
                return False
        case default:
            return False 


def reset():
    random_number.clear()
    if platform.system() == "Windows":
        os.system("cls")
    else:
        os.system("clear")



while True:
    reset()
    print("Welcome to the card guessing game!")
    card_generation()
    first = random_number[0]
    second = random_number[1]
    #print(second_output) # for testing purposes
    print(f"The first card is: {dictionizer(first)}")
    print("Is the next card higher or lower?. Please enter higher or lower")
    user_input = input("Enter higher or lower: ").lower().strip()
    if higher_or_lower(user_input, first, second) == True:
        print(f"You are correct! The next card was: {dictionizer(second)}")
        try_again = input("Do you want to play again? Enter yes or no: ").lower().strip()
        if try_again == "yes":
            reset()
        else:
            print("Thanks for playing!")
            break       
    else:
        print(f"You are wrong! The correct answer was {dictionizer(second)}")
        try_again = input("Do you want to play again? Enter yes or no: ").lower().strip()
        if try_again == "yes":
            reset()
        else:
            print("Thanks for playing!")
            break