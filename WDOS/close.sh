#!/bin/bash

read -p "Enter a number: " num

if ! [[ "$num" =~ ^[0-9]+$ ]]; then
  echo "Invalid. Int only"
fi

temp=$num
sum=0
reversed=0
while [ $temp -ne 0 ]; do
  digit=$((temp % 10))
  reversed=$((reversed * 10 + digit))
  sum=$((sum + digit))
  temp=$((temp / 10))
done
echo "Reversed: $reversed"
echo "Sum: $sum"
