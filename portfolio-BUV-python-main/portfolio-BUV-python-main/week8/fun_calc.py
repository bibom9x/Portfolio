def add(a, b, result):
    result = a + b
    return result
def sub(a, b, result):
    result = a - b
    return result
def mul(a, b, result):
    result = a * b
    return result
def div(a, b, result):
    result = a / b
    return result

def main():
    a = int(input("Enter first number: "))
    b = int(input("Enter second number: "))
    result = 0
    print("1. Addition")
    print("2. Subtraction")
    print("3. Multiplication")
    print("4. Division")
    choice = int(input("Enter your choice: "))
    match choice:
        case 1:
            add(a, b, result)
        case 2:
            sub(a, b, result)
        case 3:
            mul(a, b, result)
        case 4:
            div(a, b, result)
        case _:
            print("Invalid choice")
    print("Result: ", result)

if __name__ == "__main__":
    main()