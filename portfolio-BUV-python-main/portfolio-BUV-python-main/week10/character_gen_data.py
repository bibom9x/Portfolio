import json 
from prettytable import PrettyTable

# Open the file and load the data
with open('classes.json') as f:
    data = json.load(f)

def gen_table(data):
    stat_table = PrettyTable()
    if data:
        first_class = next(iter(data)) # get the first class name
        stat_table.field_names = ["Class"] + list(data[first_class].keys()) # get the stats from the first class

        for class_name, stats in data.items(): # iterate over the classes
            stat_table.add_row([class_name] + list(stats.values())) # add the class name and the stats to the table
    
    return stat_table

def main():
    print(gen_table(data))

if __name__ == "__main__":
    main()
