import cv2
import numpy as np
from tqdm import tqdm

import csv

# open the file in universal line ending mode
with open("C:\\Users\\amira\\Downloads\\Data1.csv", 'rU') as infile:
  # read the file as a dictionary for each row ({header : value})
  reader = csv.DictReader(infile)
  data = {}
  for row in reader:
    for header, value in row.items():
      try:
        data[header].append(value)
      except KeyError:
        data[header] = [value]

with open("C:\\Users\\amira\\Downloads\\Data2.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader1 = csv.DictReader(infile)
  data1 = {}
  for row1 in reader1:
    for header1, value1 in row1.items():
      try:
        data1[header1].append(value1)
      except KeyError:
        data1[header1] = [value1]

with open("C:\\Users\\amira\\Downloads\\Data3.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader2 = csv.DictReader(infile)
  data2 = {}
  for row2 in reader2:
    for header2, value2 in row2.items():
      try:
        data2[header2].append(value2)
      except KeyError:
        data2[header2] = [value2]

with open("C:\\Users\\amira\\Downloads\\Data4.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader3 = csv.DictReader(infile)
  data3 = {}
  for row3 in reader3:
    for header3, value3 in row3.items():
      try:
        data3[header3].append(value3)
      except KeyError:
        data3[header3] = [value3]

with open("C:\\Users\\amira\\Downloads\\Data5.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader4 = csv.DictReader(infile)
  data4 = {}
  for row4 in reader4:
    for header4, value4 in row4.items():
      try:
        data4[header4].append(value4)
      except KeyError:
        data4[header4] = [value4]

with open("C:\\Users\\amira\\Downloads\\Data6.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader5 = csv.DictReader(infile)
  data5 = {}
  for row5 in reader5:
    for header5, value5 in row5.items():
      try:
        data5[header5].append(value5)
      except KeyError:
        data5[header5] = [value5]

with open("C:\\Users\\amira\\Downloads\\Data7.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader6 = csv.DictReader(infile)
  data6 = {}
  for row6 in reader6:
    for header6, value6 in row6.items():
      try:
        data6[header6].append(value6)
      except KeyError:
        data6[header6] = [value6]

with open("C:\\Users\\amira\\Downloads\\Data8.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader7 = csv.DictReader(infile)
  data7 = {}
  for row7 in reader7:
    for header7, value7 in row7.items():
      try:
        data7[header7].append(value7)
      except KeyError:
        data7[header7] = [value7]

with open("C:\\Users\\amira\\Downloads\\Data9.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader8 = csv.DictReader(infile)
  data8 = {}
  for row8 in reader8:
    for header8, value8 in row8.items():
      try:
        data8[header8].append(value8)
      except KeyError:
        data8[header8] = [value8]

with open("C:\\Users\\amira\\Downloads\\Data10.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader9 = csv.DictReader(infile)
  data9 = {}
  for row9 in reader9:
    for header9, value9 in row9.items():
      try:
        data9[header9].append(value9)
      except KeyError:
        data9[header9] = [value9]

with open("C:\\Users\\amira\\Downloads\\Data11.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader10 = csv.DictReader(infile)
  data10 = {}
  for row10 in reader10:
    for header10, value10 in row10.items():
      try:
        data10[header10].append(value10)
      except KeyError:
        data10[header10] = [value10]

with open("C:\\Users\\amira\\Downloads\\Data12.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader11 = csv.DictReader(infile)
  data11 = {}
  for row11 in reader11:
    for header11, value11 in row11.items():
      try:
        data11[header11].append(value11)
      except KeyError:
        data11[header11] = [value11]

with open("C:\\Users\\amira\\Downloads\\Data13.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader12 = csv.DictReader(infile)
  data12 = {}
  for row12 in reader12:
    for header12, value12 in row12.items():
      try:
        data12[header12].append(value12)
      except KeyError:
        data12[header12] = [value12]

with open("C:\\Users\\amira\\Downloads\\Data14.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader13 = csv.DictReader(infile)
  data13 = {}
  for row13 in reader13:
    for header13, value13 in row13.items():
      try:
        data13[header13].append(value13)
      except KeyError:
        data13[header13] = [value13]

with open("C:\\Users\\amira\\Downloads\\Data15.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader14 = csv.DictReader(infile)
  data14 = {}
  for row14 in reader14:
    for header14, value14 in row14.items():
      try:
        data14[header14].append(value14)
      except KeyError:
        data14[header14] = [value14]

with open("C:\\Users\\amira\\Downloads\\Data16.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader15 = csv.DictReader(infile)
  data15 = {}
  for row15 in reader15:
    for header15, value15 in row15.items():
      try:
        data15[header15].append(value15)
      except KeyError:
        data15[header15] = [value15]

with open("C:\\Users\\amira\\Downloads\\Data17.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader16 = csv.DictReader(infile)
  data16 = {}
  for row16 in reader16:
    for header16, value16 in row16.items():
      try:
        data16[header16].append(value16)
      except KeyError:
        data16[header16] = [value16]

with open("C:\\Users\\amira\\Downloads\\Data18.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader17 = csv.DictReader(infile)
  data17 = {}
  for row17 in reader17:
    for header17, value17 in row17.items():
      try:
        data17[header17].append(value17)
      except KeyError:
        data17[header17] = [value17]

with open("C:\\Users\\amira\\Downloads\\Data19.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader18 = csv.DictReader(infile)
  data18 = {}
  for row18 in reader18:
    for header18, value18 in row18.items():
      try:
        data18[header18].append(value18)
      except KeyError:
        data18[header18] = [value18]

with open("C:\\Users\\amira\\Downloads\\Data20.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader19 = csv.DictReader(infile)
  data19 = {}
  for row19 in reader19:
    for header19, value19 in row19.items():
      try:
        data19[header19].append(value19)
      except KeyError:
        data19[header19] = [value19]

with open("C:\\Users\\amira\\Downloads\\Data21.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader20 = csv.DictReader(infile)
  data20 = {}
  for row20 in reader20:
    for header20, value20 in row20.items():
      try:
        data20[header20].append(value20)
      except KeyError:
        data20[header20] = [value20]

with open("C:\\Users\\amira\\Downloads\\Data22.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader21 = csv.DictReader(infile)
  data21 = {}
  for row21 in reader21:
    for header21, value21 in row21.items():
      try:
        data21[header21].append(value21)
      except KeyError:
        data21[header21] = [value21]

with open("C:\\Users\\amira\\Downloads\\Data23.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader22 = csv.DictReader(infile)
  data22 = {}
  for row22 in reader22:
    for header22, value22 in row22.items():
      try:
        data22[header22].append(value22)
      except KeyError:
        data22[header22] = [value22]

with open("C:\\Users\\amira\\Downloads\\Data24.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader23 = csv.DictReader(infile)
  data23 = {}
  for row23 in reader23:
    for header23, value23 in row23.items():
      try:
        data23[header23].append(value23)
      except KeyError:
        data23[header23] = [value23]

with open("C:\\Users\\amira\\Downloads\\Data25.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader24 = csv.DictReader(infile)
  data24 = {}
  for row24 in reader24:
    for header24, value24 in row24.items():
      try:
        data24[header24].append(value24)
      except KeyError:
        data24[header24] = [value24]

with open("C:\\Users\\amira\\Downloads\\Data26.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader25 = csv.DictReader(infile)
  data25 = {}
  for row25 in reader25:
    for header25, value25 in row25.items():
      try:
        data25[header25].append(value25)
      except KeyError:
        data25[header25] = [value25]

with open("C:\\Users\\amira\\Downloads\\Data27.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader26 = csv.DictReader(infile)
  data26 = {}
  for row26 in reader26:
    for header26, value26 in row26.items():
      try:
        data26[header26].append(value26)
      except KeyError:
        data26[header26] = [value26]

with open("C:\\Users\\amira\\Downloads\\Data28.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader27 = csv.DictReader(infile)
  data27 = {}
  for row27 in reader27:
    for header27, value27 in row27.items():
      try:
        data27[header27].append(value27)
      except KeyError:
        data27[header27] = [value27]

with open("C:\\Users\\amira\\Downloads\\Data29.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader28 = csv.DictReader(infile)
  data28 = {}
  for row28 in reader28:
    for header28, value28 in row28.items():
      try:
        data28[header28].append(value28)
      except KeyError:
        data28[header28] = [value28]

with open("C:\\Users\\amira\\Downloads\\Data30.csv", 'rU') as infile:
# read the file as a dictionary for each row ({header : value})
  reader29 = csv.DictReader(infile)
  data29 = {}
  for row29 in reader29:
    for header29, value29 in row29.items():
      try:
        data29[header29].append(value29)
      except KeyError:
        data29[header29] = [value29]


# extract the variables you want
x = data["Coordinate X"]
y = data["Coordinate Y"]

final = []
for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

      # extract the variables you want
x = data1["Coordinate X"]
y = data1["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data2["Coordinate X"]
y = data2["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])      

x = data3["Coordinate X"]
y = data3["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data4["Coordinate X"]
y = data4["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data5["Coordinate X"]
y = data5["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data6["Coordinate X"]
y = data6["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data7["Coordinate X"]
y = data7["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data8["Coordinate X"]
y = data8["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data9["Coordinate X"]
y = data9["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data10["Coordinate X"]
y = data10["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data11["Coordinate X"]
y = data11["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data12["Coordinate X"]
y = data12["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data13["Coordinate X"]
y = data13["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data14["Coordinate X"]
y = data14["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data15["Coordinate X"]
y = data15["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data16["Coordinate X"]
y = data16["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data17["Coordinate X"]
y = data17["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data18["Coordinate X"]
y = data18["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data19["Coordinate X"]
y = data19["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data20["Coordinate X"]
y = data20["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data21["Coordinate X"]
y = data21["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data22["Coordinate X"]
y = data22["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data23["Coordinate X"]
y = data23["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data24["Coordinate X"]
y = data24["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data25["Coordinate X"]
y = data25["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data26["Coordinate X"]
y = data26["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data27["Coordinate X"]
y = data27["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data28["Coordinate X"]
y = data28["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

x = data29["Coordinate X"]
y = data29["Coordinate Y"]

for z in range(len(x)):
    if x[z] != 'NaN' and y[z] != 'NaN' :
      final.append([float(x[z]), float(y[z]), 1])

#print(*final)
# extract the variables you want
"""
x = data["Coordinate X"]
y = data["Coordinate Y"]
final = []
for z in range(1, len(x)):
    final.append([int(float(x[z])), int(float(y[z])), 1])
"""



def GaussianMask(sizex,sizey, sigma=33, center=None,fix=1):
    """
    sizex  : mask width
    sizey  : mask height
    sigma  : gaussian Sd
    center : gaussian mean
    fix    : gaussian max
    return gaussian mask
    """
    x = np.arange(0, sizex, 1, float)
    y = np.arange(0, sizey, 1, float)
    x, y = np.meshgrid(x,y)

    if center is None:
        x0 = sizex // 2
        y0 = sizey // 2
    else:
        if np.isnan(center[0])==False and np.isnan(center[1])==False:
            x0 = center[0]
            y0 = center[1]
        else:
            return np.zeros((sizey,sizex))

    return fix*np.exp(-4*np.log(2) * ((x-x0)**2 + (y-y0)**2) / sigma**2)

def Fixpos2Densemap(fix_arr, width, height, imgfile, alpha=0.5, threshold=10):
    """
    fix_arr   : fixation array number of subjects x 3(x,y,fixation)
    width     : output image width
    height    : output image height
    imgfile   : image file (optional)
    alpha     : marge rate imgfile and heatmap (optional)
    threshold : heatmap threshold(0~255)
    return heatmap
    """

    heatmap = np.zeros((H,W), np.float32)
    for n_subject in tqdm(range(fix_arr.shape[0])):
        heatmap += GaussianMask(W, H, 33, (fix_arr[n_subject,0],fix_arr[n_subject,1]),
                                fix_arr[n_subject,2])

    # Normalization
    heatmap = heatmap/np.amax(heatmap)
    heatmap = heatmap*255
    heatmap = heatmap.astype("uint8")

    if imgfile.any():
        # Resize heatmap to imgfile shape
        h, w, _ = imgfile.shape
        heatmap = cv2.resize(heatmap, (w, h))
        heatmap_color = cv2.applyColorMap(heatmap, cv2.COLORMAP_JET)

        # Create mask
        mask = np.where(heatmap<=threshold, 1, 0)
        mask = np.reshape(mask, (h, w, 1))
        mask = np.repeat(mask, 3, axis=2)

        # Marge images
        marge = imgfile*mask + heatmap_color*(1-mask)
        marge = marge.astype("uint8")
        marge = cv2.addWeighted(imgfile, 1-alpha, marge,alpha,0)
        return marge

    else:
        heatmap = cv2.applyColorMap(heatmap, cv2.COLORMAP_JET)
        return heatmap

if __name__ == '__main__':
    # Load image file
    img = cv2.imread('White.png')  

    # Generate toy fixation data
    # when you use, replace here with your data
    num_subjects = 40
    H, W, _ = img.shape

    fix_arr = np.array(final)

    # Create heatmap
    heatmap = Fixpos2Densemap(np.array(final, dtype = float), W, H, img, 0.7, 5)
    cv2.imwrite("C:\\Users\\amira\\Downloads\\Output3.png", heatmap)