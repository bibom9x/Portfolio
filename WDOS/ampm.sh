#!/bin/bash

read -p "Enter time: " time

if [[ "$time" =~ ^[0-9]+$ ]] && [[ "$stime" -ge 0 ]] && [[ "$time" -le 24 ]]; then
  if [[ "$time" -le 12 ]]; then
    echo "AM"
  else
    echo "PM"
  fi
else
  echo "Invalid Input. Int only"
fi
