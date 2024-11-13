#!/bin/bash

read -p "Enter dir path" dir

if [ -d "$dir" ]; then
  count=$(find "$dir" -type f -name "*.txt" | wc -l )
  echo "Total number of file in $dir: $count"
else
  echo "Dir not found"
fi
