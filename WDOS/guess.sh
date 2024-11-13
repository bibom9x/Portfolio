#!bin/bash

file="/c/Users/bibom/WDOS"

count=$(find "$file" -type f | wc -l)

read -p "Enter your guess: " guess

if ! [[ "$guess" =~ ^[0-9]+$ ]]; then
  echo "Positive int only."
  exit
fi

if [[ "$guess" -lt "$count" ]]; then
  echo "More"
elif [[ "$guess" -gt "$count" ]]; then
  echo "Less"
else
  echo "Your guess is correct, the answer is $count"
fi
