candies = int(input("Enter the amount of candies in packet: "))
Students = int(input("Enter the amount of students: "))

leftovers = candies % Students
recieve = (candies - leftovers) / Students

print("Number of candies student will receive: ", recieve)
print("Number of leftovers that the student will keep: ", leftovers)
