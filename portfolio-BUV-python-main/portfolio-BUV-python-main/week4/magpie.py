def magpie(input):
    match input:
        case 1:
            return "One for sorrow"
        case 2: 
            return "Two for joy"
        case 3:
            return "Three for a girl"
        case 4:
            return "Four for a boy"
        case 5:
            return "Five for silver"
        case 6:
            return "Six for gold"
        case 7:
            return "Seven for a secret never to be told"
        
        
while True:
    num_input = int(input("Enter a number: "))
    if num_input > 0 and num_input < 8:
        print(magpie(num_input))
        break
    else:
        print("Not a permitted number")

