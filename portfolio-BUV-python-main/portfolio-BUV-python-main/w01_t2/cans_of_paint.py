import math 

Hall_L = 40 #meters
Hall_W = 30 #meters
Hall_H = 3.4 #meters
paint_cover_per_can = 5.1 #sqrt meters


can_diameter = 0.15 # meters = 15 cm
can_height = 0.30 # meters = 30 cm 
can_volume = math.pi * (can_diameter / 2)**2 * can_height # pi * r^2 * h
box_vol = 0.60 * 0.30 * 0.35




wall_area = 2 * (Hall_L + Hall_W) * Hall_H # 2 * (L + W) * H
min_cans_needed = math.ceil(wall_area/paint_cover_per_can) 
boxs_needed = math.ceil(min_cans_needed + can_volume / box_vol) 


print("The min amount of paint cans needed for one floor is: ", min_cans_needed)
print("The amount of boxes they need is buy is: ", boxs_needed)
