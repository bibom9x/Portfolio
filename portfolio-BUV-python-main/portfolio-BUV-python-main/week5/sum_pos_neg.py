positive = []
negative = []

dict = {
    0: 'first',
    1: 'second',
    2: 'third',
    3: 'fourth',
    4: 'fifth'
}

def positive_or_negative(num):
    if num < 0:
        negative.append(num)
    elif num > 0:
        positive.append(num)

for i in range(0, 5):
    number = int(input(f"Enter the {dict[i]} number: "))
    positive_or_negative(number)

print(f"Sum of positive numbers: {sum(positive)}")
print(f"Sum of negative numbers: {sum(negative)}")