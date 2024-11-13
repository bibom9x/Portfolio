def reverse(number):
    reverse = 0
    while number > 0:
        lastDigit = number % 10
        reverse = (reverse * 10) + lastDigit
        number = number // 10
    return reverse # https://medium.com/@ManBearPigCode/how-to-reverse-a-number-mathematically-97c556626ec6

number = int(input("Enter a number: "))
print(f"Reversed number: {reverse(number)}")