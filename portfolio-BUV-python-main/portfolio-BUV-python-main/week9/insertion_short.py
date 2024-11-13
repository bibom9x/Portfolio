def sort_low_to_high(arr):
    for i in range (1, len(arr)): # for each element in the array
        key = arr[i]  # set the key to the element
        j = i - 1  # set the index to the element before it
        while j >= 0 and key < arr[j]: # if key is less than the element before it
            arr[j+1] = arr[j] # move the element before it to the right
            j -= 1 # move the index to the left
        arr[j+1] = key # insert the key into the correct position
    return arr # return the sorted array

def sort_high_to_low(arr):
    for i in range (1, len(arr)): # for each element in the array
        key = arr[i] # set the key to the element
        j = i - 1 # set the index to the element before it
        while j >= 0 and key > arr[j]: # if key is greater than the element before it
            arr[j+1] = arr[j] # move the element before it to the right
            j -= 1 # move the index to the left
        arr[j+1] = key # insert the key into the correct position
    return arr

def main():
    list = []
    for i in range(0, 5):
        number = int(input(f"Enter the digit number {i} "))
        list.append(number)
    print(f"Low to high: {sort_low_to_high(list)}")
    print(f"High to low: {sort_high_to_low(list)}")

if __name__ == "__main__":
    main()