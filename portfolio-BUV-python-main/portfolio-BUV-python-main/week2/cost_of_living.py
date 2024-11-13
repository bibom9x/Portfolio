from tabulate import tabulate
rent = float(input("Enter the rent per month: "))
gas = float(input("Enter the gas input per month: "))
electric = float(input("Enter the electricity bill per month: "))
water = float(input("Enter the water bill per month: "))
council_tax = float(input("Enter the council tax per month: "))

print("Rent per month: ", rent)
print("Gas payment per month: ", gas)
print("Electricity payment per month: ", electric)
print("Water payment per month: ", water)
print("Council tax payment per month: ", council_tax)
print("Your monthly expenses are:")
table = [["Rent","$",rent], ["Gas","$",gas], ["Electricity","$",electric], ["Water","$",water], ["Council tax","$",council_tax]]

print(tabulate(table))