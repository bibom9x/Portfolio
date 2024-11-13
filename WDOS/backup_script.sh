#!/bin/bash

#######################################
# Author: Your Name
# Date Created: YYYY-MM-DD
# Last Modified: YYYY-MM-DD
# Description: This script backs up all files in the home directory into a .tar archive.
# Usage: ./backup_script
#######################################

# Backup directory
backup_dir="$HOME/backup"

# Create backup directory if it doesn't exist
mkdir -p "$backup_dir"

# Archive filename with timestamp
archive_file="$backup_dir/home_backup_$(date +%Y%m%d%H%M%S).tar"

# Change directory to home directory
cd "$HOME" || { echo "Error: Cannot change directory to $HOME"; exit 1; }

# Create a tar archive of the home directory
tar -cf "$archive_file" .

# Check if tar command succeeded
if [ $? -eq 0 ]; then
  echo "Backup successful. Archive saved as $archive_file"
else
  echo "Backup failed!"
  exit 1
fi

exit 0
