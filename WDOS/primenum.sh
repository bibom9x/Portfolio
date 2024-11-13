#!/bin/bash

read -p "Enter a number: " num

if ! [[ "$num" =~ ^[0-9]+$ ]]; then
  echo "Positive int only"
  exit
fi

if [[ "$num" -le 1 ]]; then
 echo "Not a prime"
 exit
fi

for ((i=2; i * i <= num; i++)); do
  if ((num % i == 0)); then
    echo "Not a prime"
    exit
  fi
done

echo "Prime"

