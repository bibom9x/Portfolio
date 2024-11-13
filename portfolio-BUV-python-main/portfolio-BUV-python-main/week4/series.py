positive = []
negative = []
order = ['first', 'second', 'third', 'fourth', 'fifth']

def positive_or_negative(input):
    if input < 0:
        negative.append(input)
    elif input > 0:
        positive.append(input)
    else:
        pass
    


for i in range(0, 5):
    number = int(input(f"Enter the {order[i]} number: "))
    positive_or_negative(number)

print(f"Sum of positive numbers: {sum(positive)}")
print(f"Sum of negative numbers: {sum(negative)}")
print(f"Sum of all numbers: {sum(positive) + sum(negative)}")
