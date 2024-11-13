#!/bin/bash

read -p "Enter the time (0-24)" time

if [[ "$time" =~ ^[0-9]+$ ]] && [[ "$time" -ge 0 ]] && [[ "$time" -le 24 ]]; then
  if [[ "$time" -le 12 ]]; then
    echo "AM"
  else
    echo "PM"
  fi
else
  echo "Invalid"
fi
