#!/bin/bash

# Check if a directory path is provided as a command-line argument
if [ -z "$1" ]; then
  echo "Usage: $0 directory_path"
  exit 1
fi

# Store the provided directory path in a variable
dir_path="$1"

# Check if the entered path is a directory
if [ ! -d "$dir_path" ]; then
  echo "Invalid directory path."
  exit 1
fi

# Count the total number of files (including hidden files) in the directory
total_files=$(find "$dir_path" -type f | wc -l)

# Print the total number of files
echo "Total number of files (including hidden files) in $dir_path: $total_files"
