height_feet = int(input("Enter your height in feet: "))
height_inches = int(input("Enter your height in inches: "))

height_kilometers = (height_feet * 0.0003048) + (height_inches * 0.0000254)
height_meters = height_kilometers * 1000
height_centimeters = height_meters * 100
height_millimeters = height_centimeters * 10

print(f"Your height in kilometers is: {height_kilometers}")
print(f"Your height in meters is: {height_meters}")
print(f"Your height in centimeters is: {height_centimeters}")
print(f"Your height in millimeters is: {height_millimeters}")
