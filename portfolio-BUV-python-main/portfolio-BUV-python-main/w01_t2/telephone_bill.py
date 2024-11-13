mins = int(input("Enter the number of minutes: "))
print("Enter the number of minutes used:")
basic_charge = float(15*mins)
vat = (20*basic_charge)/100.0
print(f"Basic call charge: {basic_charge} $")
print(f"VAT due: {vat} $")
print(f"Total bill: {basic_charge + vat} $")


