shopping_list = {}

def add_to_list(item, price):
    if item in shopping_list:
        shopping_list[item] += price
    else:
        shopping_list[item] = price

def main():
    try:
        amount = int(input("How many items do you want to add? "))
        for i in range(amount):
            item = input(f"Enter item number {i}: ")
            price = float(input(f"Enter the price of item number {i}: "))
            add_to_list(item, price)
            sorted_prices = sorted(shopping_list.items(), key=lambda x: x[1]) # sort by price 
        print(f"Your shopping list is: {sorted_prices}")
    except ValueError:
        print("Please enter a valid number") 
        main()

if __name__ == "__main__":
    main()