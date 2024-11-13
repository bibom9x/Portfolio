#!/bin/bash

read -p "Enter a number: " number
sum=0
reversed=0
temp=$number
while [ $temp -ne 0 ]; do
  digit=$((temp % 10))
  reversed=$((reversed * 10 + digit))
  sum=$((sum + $digit))
  temp=$((temp / 10))
done
echo "$reversed"
echo "$sum"
