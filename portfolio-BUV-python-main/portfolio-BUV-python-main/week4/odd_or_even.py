num_input = int(input("Enter a number: "))
                
def odd_or_even(num):
    if num == 0:
        return False
    elif num % 2 == 0:
        return True
    else:
        return False
    

if odd_or_even(num_input) == True: 
    print("True")
else:
    print("False")