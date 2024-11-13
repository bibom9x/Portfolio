voting_database = {
    "Alice": 0,
    "Bob": 0,
    "Charlie": 0,
    "Diane": 0,
    "Eve": 0
}

def voting():
    while True:
        print("Welcome to the voting system.")
        print("Please pick a candidate from the list below:")
        for name, votes in voting_database.items():
            print(f"{name} has {votes} votes.")
        print("Type exit to stop the program")
        vote = input("Enter a name: ").lower()
        match vote:
            case "alice":
                voting_database["Alice"] += 1
            case "bob":
                voting_database["Bob"] += 1
            case "charlie":
                voting_database["Charlie"] += 1
            case "diane":
                voting_database["Diane"] += 1
            case "eve":
                voting_database["Eve"] += 1
            case "exit":
                print("Exiting...")
                break
            case _:
                print("Invalid input.")

if __name__ == "__main__":
    voting()