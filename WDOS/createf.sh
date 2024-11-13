#!/bin/bash

# Check if the path to the folders_to_create.txt file is provided
if [ -z "$1" ]; then
  echo "Usage: $0 /path/to/folders_to_create.txt"
  exit 1
fi

# Store the path to the file in a variable
file_path="$1"

# Check if the file exists
if [ ! -f "$file_path" ]; then
  echo "File not found: $file_path"
  exit 1
fi

# Read the file line by line and create directories
while IFS= read -r directory; do
  # Check if the directory name is not empty
  if [ -n "$directory" ]; then
    mkdir -p "$directory"
    echo "Created directory: $directory"
  fi
done < "$file_path"
