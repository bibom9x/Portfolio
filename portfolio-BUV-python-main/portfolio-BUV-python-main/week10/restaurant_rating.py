rating_count = {"Terrible": 0, "Poor": 0, "Average": 0, "Good": 0, "Excellent": 0}

def rating_input(rating):
    match rating:
        case 1:
            rating_count["Terrible"] += 1
            return True
        case 2:
            rating_count["Poor"] += 1
            return True
        case 3:
            rating_count["Average"] += 1
            return True
        case 4:
            rating_count["Good"] += 1
            return True
        case 5:
            rating_count["Excellent"] += 1
            return True
        case -1:
            return False
        case _:
            raise ValueError

            

def main():
    try:
        while True:
            print("Welcome to the restaurant rater!")
            print("Enter your rating")
            print("1. Terrible")
            print("2. Poor")
            print("3. Average")
            print("4. Good")
            print("5. Excellent")
            print("Enter -1 to quit")
            rating = int(input("Enter your rating: "))
            if rating_input(rating): # if rating_input returns True, continue
                continue
            else: # if rating_input returns False, break
                print("Rating analysis:")
                for key, value in rating_count.items():
                    print(f"{value} people voted {key}")
                break
    except ValueError:
        print("Please enter a valid rating")
        main()

if __name__ == "__main__":
    main()