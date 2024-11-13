#!/bin/bash

read -p "Enter the directory name: " dir

if [ -d "$dir" ]; then
  echo "Dir already exist"
else 
  mkdir "$dir" 
  echo "Dir created: $dir"
fi

#!/bin/bash
read -p "Enter directory name: " dir
if [ -d "$dir" ]; then
    echo "Directory $dir already exists."
else
    mkdir "$dir"
    echo "Directory $dir created."
fi

#Write a bash script to calculate the factorial of a given number.

#!/bin/bash
read -p "Enter a number: " num
factorial=1
for (( i=1; i<=num; i++ )); do
    factorial=$((factorial * i))
done
echo "The factorial of $num is $factorial."

#Write a bash script to check if a given year is a leap year.

#!/bin/bash
read -p "Enter a year: " year
if (( (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 )); then
    echo "$year is a leap year."
else
    echo "$year is not a leap year."
fi

#largest of three numbers entered
#!/bin/bash
read -p "Enter first number: " num1
read -p "Enter second number: " num2
read -p "Enter third number: " num3

if (( num1 >= num2 && num1 >= num3 )); then
    echo "$num1 is the largest number."
elif (( num2 >= num1 && num2 >= num3 )); then
    echo "$num2 is the largest number."
else
    echo "$num3 is the largest number."
fi

#number of words
#!/bin/bash
read -p "Enter the file name: " file
if [ -f "$file" ]; then
    words=$(wc -w < "$file")
    echo "The file $file has $words words."
else
    echo "Error: File $file does not exist."
fi

#file exist or not
#!/bin/bash
read -p "Enter the file name: " file
if [ -f "$file" ]; then
    echo "File $file exists."
else
    echo "File $file does not exist."
fi



