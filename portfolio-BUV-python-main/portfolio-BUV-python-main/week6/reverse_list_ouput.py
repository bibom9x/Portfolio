number1 = int(input("Enter the first number: "))
number2 = int(input("Enter the second number: "))
number3 = int(input("Enter the third number: "))
number4 = int(input("Enter the fourth number: "))
number5 = int(input("Enter the fifth number: "))

list = [number1, number2, number3, number4, number5]
reversed_list = []
def reverse_list_output():
    for item in list:
        reversed_list.insert(0, item) # insert item at index 0
    print(list)
    print(reversed_list)

if __name__ == "__main__":
    reverse_list_output()