
#!/bin/bash

# Function to check if input is a valid hour
is_valid_hour() {
  local hour=$1
  if [[ $hour -ge 0 && $hour -le 24 ]]; then
    return 0
  else
    return 1
  fi
}

# Check if an argument is provided
if [ -z "$1" ]; then
  echo "Usage: $0 <hour>"
  exit 1
fi

# Get the input hour
hour=$1

# Check if the input is a valid number
if ! [[ $hour =~ ^[0-9]+$ ]]; then
  echo "Error: Input is not a valid number."
  exit 1
fi

# Check if the input is a valid hour
if ! is_valid_hour $hour; then
  echo "Error: Hour must be between 0 and 24."
  exit 1
fi

# Determine AM or PM
if [ $hour -ge 0 ] && [ $hour -lt 12 ]; then
  echo "AM"
elif [ $hour -ge 12 ] && [ $hour -le 24 ]; then
  echo "PM"
fi

