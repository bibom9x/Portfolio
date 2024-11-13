#!/bin/bash

current_year=$(date '+ %Y')

read -p "Enter your age" yob

age=$((current_year - yob))

echo "$age"
