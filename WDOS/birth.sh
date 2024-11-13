#!/bin/bash

current_year=$(date '+ %Y')

read -p "Enter your age: " age

result=$((current_year - age))

  echo "Your birth year: $result"
