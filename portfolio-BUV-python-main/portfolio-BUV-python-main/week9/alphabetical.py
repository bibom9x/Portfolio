wordlist = []
def main():
    i = 1    
    while i <= 5:
        raw = input(f"Enter the word number {i}: ")
        if raw.isalpha():
            wordlist.append(raw)
            i += 1
        else:
            print("Please enter a valid word")
            i = 0
    wordlist.sort()
    print(*wordlist, sep= ", ")
    
if __name__ == "__main__":
     main()