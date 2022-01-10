import cv2
import numpy as np
import pandas as pb
import math
from fastseg import MobileV3Large, MobileV3Small
from fastseg.image import colorize, blend
import cv2
model = MobileV3Small.from_pretrained().cuda()
model.eval()
import numpy as np
import time
# Open a local image as input
from PIL import Image
import pickle
import json

from PIL import Image
image = Image.open("C:\\Users\\krish\\Downloads\\unknown.png").convert('RGB')


labels = model.predict_one(image)


from fastseg.image import colorize, blend

colorized = colorize(labels)
colorized.show()

composited = blend(image, colorized)
composited.show()



writer = None

allLabels = []

# get all videos in cv2 object

video_names = ["Video25"]
#VIDEO 6 later



vs_objects = []
for video in video_names:
    video_path_part_1 = "C:\\Users\\krish\\Downloads\\ScienceFairOrderedVideos\\"
    video_path_part_2 = video
    video_path_part_3 = "_Trim_Trim.mp4"
    video_final_path = video_path_part_1 + video_path_part_2 + video_path_part_3
    vs = cv2.VideoCapture(video_final_path)
    vs_objects.append(vs)

# get all participant data
list_of_names = ["Andy"] # put all participant names here
data_frames = []
count = 0
composited_indexes = []
indexVSObjects = vs_objects.copy()
for vs in vs_objects:
    tempLabels = []
    while True:
        (grabbed, frame) = vs.read()
        if not grabbed:
            break
        labels = model.predict_one(frame)
        #print(*labels)
        #print(len(labels))
        #print(len(labels[0]))
        tempLabels.append(labels)
        print(".")
    print("videocompleted")
    import h5py
    f1 = h5py.File("Video25.hdf5", "w")
    dset1 = f1.create_dataset("labels", (len(tempLabels), 1080, 1920), dtype='i', data=tempLabels)
    f1.close()
    #allLabels.append(tempLabels)
    #vs.release()

