#!/bin/bash

read -p "Enter : " number

if ! [[ "$number" =~ ^[0-9]+$ ]]; then
  echo "Invalid. Int only"
  exit
fi

if (( number <= 1 )); then
  echo "Not a prime"
  exit
fi

for (( i=2; i * i <= number; i++)); do
  if (( number % i == 0 )); then
    echo "Not a prime"
    exit
  fi
done

echo "Prime"
