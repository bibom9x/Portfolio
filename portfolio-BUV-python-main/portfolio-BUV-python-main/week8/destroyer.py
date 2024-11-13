from random import randint

Hidden_Pattern=[[' ']*5 for _ in range(5)]
Guess_Pattern=[[' ']*5 for _ in range(5)]

let_to_num={
    'A':0, 
    'B':1, 
    'C':2, 
    'D':3, 
    'E':4
}

def print_board(board):
    print(' A B C D E')
    print(' *********')
    row_num=1
    for row in board:
        print("%d|%s|" % (row_num, "|".join(row))) # join the elements of the row with a pipe
        row_num +=1

def get_ship_location():
    row=input('Please enter a ship row from 1 to 5 ').upper()
    while row not in '12345':
        print("Please enter a valid row ")
        row=input('Please enter a ship row 1-5 ')
    column=input('Please enter a ship column from A to E ').upper()
    while column not in 'ABCDE':
        print("Please enter a valid column ")
        column=input('Please enter a ship column A to E ')
    return int(row)-1,let_to_num[column]


def create_ships(board):
    for _ in range(4):
        ship_r, ship_cl=randint(0,4), randint(0,4)
        while board[ship_r][ship_cl] =='X':
            ship_r, ship_cl = randint(0, 4), randint(0, 4)
        board[ship_r][ship_cl] = 'X'



def count_hit_ships(board):
    count=0
    for row in board:
        for column in row:
            if column=='X':
                count+=1
    return count

create_ships(Hidden_Pattern)
print_board(Hidden_Pattern)
turns = 10
while turns > 0:
    print('Welcome to Battleship')
    print_board(Guess_Pattern)
    row,column =get_ship_location()
    if Guess_Pattern[row][column] == '-':
        print(' You already guessed that ')
    elif Hidden_Pattern[row][column] =='X':
        print(' Congratulations you have hit the battleship ')
        Guess_Pattern[row][column] = 'X'
        turns -= 1
    else:
        print('Sorry,You missed')
        Guess_Pattern[row][column] = '-'
        turns -= 1
    if  count_hit_ships(Guess_Pattern) == 5:
        print("Congratulations you have sunk all the battleships ")
        break
    print(' You have ' +str(turns) + ' turns remaining ')
    if turns == 0:
        print('Game Over ')
        break