import random

number = random.randint(1, 13)

def card_checker(num):
    match num:
        case 1:
            return "Ace"
        case 11: 
            return "Jack"
        case 12:
            return "Queen"
        case 13:
            return "King"
        case default:
            return num

print(f"The random number is: {number}")
print(f"The card is: {card_checker(number)}")