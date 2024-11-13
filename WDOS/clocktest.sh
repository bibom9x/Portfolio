#!/bin/bash
read -p "Please enter the time (0-24): " time

if [[ "$time" =~ ^[0-9]+$ ]] && [ "$time" -ge 0 ] && [ "$time" -le 24 ]; then

  if [ "$time" -lt 12 ]; then
    echo "AM"
  else
    echo "PM"
  fi
else
  echo "Invalid time format“
fi
#!/bin/bash
# Prompt the user for input
read -p "Please enter the time (0-24): " time

# Check if the input is within the valid range
if [[ "$time" =~ ^[0-9]+$ ]] && [ "$time" -ge 0 ] && [ "$time" -le 24 ]; then
  if [ "$time" -lt 12 ]; then
    echo "AM"
  else
    echo "PM"
  fi
else
  echo "Invalid time format"
fi
#!/bin/bash
#Prompt the user for input
read -p "Please enter the time (0-24): " time
#Check if the input is within the valid range
if [[ "$time" =~ ^[0-9]+$ ]] && [ "$time" -ge 0 ] && [ "$time" -le 24 ]; then
        if [ "$time" -lt 12 ]; then
                echo "AM"
        else
                echo "PM"
        fi
else
        echo "Invalid format“
fi


#!/bin/bash
# Prompt the user for input
read -p "Please enter the time (0-24): " time

# Check if the input is within the valid range
if [[ "$time" =~ ^[0-9]+$ ]] && [ "$time" -ge 0 ] && [ "$time" -le 24 ]; then
  if [ "$time" -lt 12 ]; then
    echo "AM"
  else
    echo "PM"
  fi
else
  echo "Invalid time format"
fi
#!/bin/bash
#Prompt the user for input
read -p "Please enter the time (0-24): " time
#Check if the input is within the valid range
if [[ "$time" =~ ^[0-9]+$ ]] && [ "$time" -ge 0 ]read -p "Please enter the time (0-24): " time

if [[ "$time" =~ ^[0-9]+$ ]] && [ "$time" -ge 0 ] && [ "$time" -le 24 ]; then

  if [ "$time" -lt 12 ]; then
    echo "AM"
  else
    echo "PM"
  fi
else
  echo "Invalid time format“
fi
	echo "Invalid format“
fi
#Prompt the user for input
read -p "Please enter the time (0-24): " time
#Check if the input is within the valid range
if [[ "$time" =~ ^[0-9]+$ ]] && [ "$time" -ge 0 ] && [ "$time" -le 24 ]; then
        if [ "$time" -lt 12 ]; then
                echo "AM"
        else
                echo "PM"
        fi
else
        echo "Invalid format“
fi


