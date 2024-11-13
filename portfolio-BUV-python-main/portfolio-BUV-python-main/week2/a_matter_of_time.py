from tabulate import tabulate
import time 
input = int(input("Enter the amount of seconds: "))
seconds = input
hours = seconds // 3600
seconds %= 3600
minutes = seconds // 60
seconds %= 60

table = [["Input", "Hours", "Minutes", "Seconds"], [input, hours, minutes, seconds]]
print(tabulate(table))