import random
import os
import platform

rock_paper_scissors_list = ["rock", "paper", "scissors"]

def computer_choice():
    return random.randint(0, 2)

def rock_paper_scissors(input, computer): # 0 = rock, 1 = paper, 2 = scissors
    if input == computer:
        return "0" # draw
    elif input == 0 and computer == 1: # rock vs paper
        return "-1" # lose
    elif input == 0 and computer == 2:  # rock vs scissors
        return "1" # win
    elif input == 1 and computer == 0: # paper vs rock
        return "1" # win
    elif input == 1 and computer == 2: # paper vs scissors
        return "-1" # lose
    elif input == 2 and computer == 0: # scissors vs rock
        return "-1" # lose
    elif input == 2 and computer == 1: # scissors vs paper
        return "1" # win


def main():
    wins = 0
    print("Welcome to Rock, Paper, Scissors!")
    while wins < 3:
        comp = computer_choice()
        choice = input("Enter your choice (rock, paper, scissors): ").strip().lower()
        if rock_paper_scissors(rock_paper_scissors_list.index(choice), comp) == "0":
            print("Draw")
            print(f"Computer chose {rock_paper_scissors_list[comp]}")
            print(f"You still need {3 - wins} wins to win the game")
        elif rock_paper_scissors(rock_paper_scissors_list.index(choice), comp) == "1":
            print("You win!")
            print(f"Computer chose {rock_paper_scissors_list[comp]}")
            wins += 1
            print(f"You still need {3 - wins} wins to win the game")
        elif rock_paper_scissors(rock_paper_scissors_list.index(choice), comp) == "-1":
            print("You lose!")
            print(f"Computer chose {rock_paper_scissors_list[comp]}")
            print(f"You still need {3 - wins} wins to win the game")

        else:
            print("Invalid input")
            continue
    try_again = input("Do you want to play again? (y/n): ").strip().lower()
    if try_again == "y":
        main()
    else:
        print("Thanks for playing!")
        exit()
if __name__ == "__main__":
    main()
        

    
     
