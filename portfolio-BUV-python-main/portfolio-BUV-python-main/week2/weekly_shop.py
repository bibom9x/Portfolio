price = 0.0
print("Peaches:")
peaches = int(input("How many? "))
peach_price = float(input("Price? "))
price = price + peaches * peach_price
beans = int(input("How many beans? "))
beans_price = float(input("Price? "))
price = price + beans * beans_price
chicken_pieces = int(input("How many chicken pieces? "))
chicken_pieces_price = float(input("Price? "))
price = price + chicken_pieces * chicken_pieces_price
Sock = int(input("How many pair of socks? "))
sock_price = float(input("Price? "))
price = price + Sock * sock_price
bottle_water = int(input("How many bottle of water? "))
bottle_water_price = float(input("Price? "))
price = price + bottle_water * bottle_water_price
print("Total amount of item bought: ", peaches + beans + chicken_pieces + Sock + bottle_water)
print("Total price: ", price)