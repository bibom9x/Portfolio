#!/bin/bash

read -p "Enter your age: "  age

if ! [[ "$age" =~ ^[0-9]+$ ]]; then
  echo "Invalid input. Positive Interger for age only"
  exit 1
fi

if [[ "$age" -eq 0 ]]; then
  echo "Age cannot be zero"
elif [[ "$age" -lt 18 ]]; then
  echo "Under 18"
else
  echo "18 & Older"
fi

