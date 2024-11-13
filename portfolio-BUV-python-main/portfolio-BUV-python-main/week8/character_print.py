def printchar(char, times):
    for i in range(times):
        print(char, end='')

def main():
    char = input("Enter a character: ")
    times = int(input("Enter a number of times: "))
    printchar(char, times)

main()