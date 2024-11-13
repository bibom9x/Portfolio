import random

def get_random_word():
    wordlist = []
    with open("hangman_wordlist.txt", "r") as f:
        for line in f:
            wordlist.append(line.strip())
    return random.choice(wordlist)

def draw_hangman(chances):
    if chances == 6:
        print("  _______")
        print(" |       |")
        print(" |")
        print(" |")
        print(" |")
        print(" |")
        print("_|_________")
    elif chances == 5:
        print("  _______")
        print(" |       |")
        print(" |       O")
        print(" |")
        print(" |")
        print(" |")
        print("_|_________")
    elif chances == 4:
        print("  _______")
        print(" |       |")
        print(" |       O")
        print(" |       |")
        print(" |")
        print(" |")
        print("_|_________")
    elif chances == 3:
        print("  _______")
        print(" |       |")
        print(" |       O")
        print(" |      /|")
        print(" |")
        print(" |")
        print("_|_________")
    elif chances == 2:
        print("  _______")
        print(" |       |")
        print(" |       O")
        print(" |      /|\\")
        print(" |")
        print(" |")
        print("_|_________")
    elif chances == 1:
        print("  _______")
        print(" |       |")
        print(" |       O")
        print(" |      /|\\")
        print(" |      /")
        print(" |")
        print("_|_________")
    elif chances == 0:
        print("  _______")
        print(" |       |")
        print(" |       O")
        print(" |      /|\\")
        print(" |      / \\")
        print(" |")
        print("_|_________")

def game():
    word = get_random_word()
    print(word)
    temp = []
    for i in range(len(word)): # Create a list of underscores the same length as the word
        temp.append("_") 
    changes = 7 
    while changes > 0:
        print(" ".join(temp)) # Print the list of underscores
        guess = input("Please enter your guess: ")
        if guess in word:
            for i in range(len(word)):
                if word[i] == guess:
                    temp[i] = guess
        else:
            changes -= 1 # Reduce the number of chances
            draw_hangman(changes) # Draw the hangman
        if "_" not in temp: # Check if the word has been guessed
            print("You win!")
            exit()
    print(f"You lose!, the word was {word}")

    

if __name__ == "__main__":
    game()