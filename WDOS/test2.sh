#!/bin/bash
#Read the number from the user
read -p "Enter a number: " number
# Reverse the number and calculate the sum of digits
reversed=0
sum=0
temp=$number
while [ $temp -ne 0 ]; do
  digit=$((temp % 10))
  reversed=$((reversed * 10 + digit))
  sum=$((sum + digit))
  temp=$((temp / 10))
done
echo "Reversed Number: $reversed"
echo "Sum of Digits: $sum"
