#!/bin/bash

if [ -z "$1" ]; then
	echo "Usage: $0 <directory>"
	exit 1
fi

directory ="$1"

if [ ! -d "$directory" ]; then
	echo "Error: $directory is not a valid directory."
	exit 1
fi

total_files=$(find "$directory" -type f | wc -1)
hidden_files=$(find "$directory" -type f -name ".*" | wc -1)

total_files_including_hidden=$((total_files + hidden_files))


if [ -z "$1" ]; then
        echo "Usage: $0 <directory>"
        exit 1
fi

directory ="$1"

if [ ! -d "$directory" ]; then
        echo "Error: $directory is not a valid directory."
        exit 1
fi

total_files=$(find "$directory" -type f | wc -1)
hidden_files=$(find "$directory" -type f -name ".*" | wc -1)

total_files_including_hidden=$((total_files + hidden_files))

echo "Total number of files (including hidden files) in '$DIRECTORY': $file_count"
