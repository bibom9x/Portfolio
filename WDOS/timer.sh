#!/bin/bash

minutes=0
seconds=0

while getopts "m:s:" opt; do
  case $opt in
    m) minutes=$OPTARG ;;
    s) seconds=$OPTARG ;;
    \?) echo "Invalid option -$OPTARG" >&2
        echo "Usage: $0 -m minutes -s seconds"
        exit 1
        ;;
  esac
done

total_seconds=$((minutes * 60 + seconds))

while [ $total_seconds -gt 0 ]; do
  echo "Time remaining: $total_seconds"
  sleep 1s
  total_seconds=$((total_seconds -1))
done
echo "Time's Up!"

