from PIL import Image
img = Image.open("MohsenHeatmap.png")

# all variables to detect
concentration = 0
FOV = 0
white = 0

# get all pixels
all_pixels = img.load()

for x in range(0, 1920):
  for y in range(0, 1080):
    # rgb values
    r_value = all_pixels[x,y][0]
    g_value = all_pixels[x,y][1]
    b_value = all_pixels[x,y][2]

    # blue buffer
    elif ((r_value in range(66, 88)) and (g_value in range(115, 151)) and (b_value in range(245, 255))):
      blue += 1

    # white buffer
    elif (r_value == g_value == b_value == 255):
      white += 1

# Accomodate for overlapping of colors

FOV = 2073600 - white
concentration = 2073600 - white - blue

print (FOV)
print (concentration)