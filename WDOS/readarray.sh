#!bin/bash

readarray -t urls < /c/Users/bibom/WDOS/urls.txt

for url in "${urls[@]}"; do
 echo "Processing URL: $url"

domain=$(echo $url | cut -d'/' -f3)

domain=$(echo $domain | sed 's/^www\.//')

base=$(echo $domain | cut -d'.' -f1)

echo "Base domain: $base"

curl -s -I $url > "${base.txt}"

if [ -f "${base}.txt" ]; then
  echo "Headers for $url saved to ${base}.txt"
else
  echo "Failed to save headers for $url"
fi
done
