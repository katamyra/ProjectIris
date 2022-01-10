import cv2
import numpy as np
import pandas as pb
import math
import os
#from fastseg import MobileV3Large, MobileV3Small
#from fastseg.image import colorize, blend
import cv2
#model = MobileV3Small.from_pretrained().cuda()
#model.eval()
import numpy as np
import time
# Open a local image as input
from PIL import Image


import h5py
writer = None

allLabels = []

# get all videos in cv2 object
#video_names = ["Video1", "Video2", "Video3", "Video4"]
#video_names = ["Video5"]
#video_names = ["Video6", "Video7", "Video8", "Video9", "Video10"]
#video_names = ["Video11", "Video12", "Video13", "Video14", "Video15"]
#video_names = ["Video16", "Video17", "Video18", "Video19"]
#video_names = ["Video25"]
#video_names = ["Video21", "Video22", "Video23", "Video24"]

video_names = ["Video26", "Video27", "Video28"]
#VIDEO 6 later



vs_objects = []
h5paths = []
for video in video_names:
    video_path_part_1 = "C:\\Users\\krish\\Downloads\\ScienceFairOrderedVideos\\"
    video_path_part_2 = video
    video_path_part_3 = "_Trim_Trim.mp4"
    video_final_path = video_path_part_1 + video_path_part_2 + video_path_part_3
    vs = cv2.VideoCapture(video_final_path)
    vs_objects.append(vs)
    tempString = "C:\\Code\\fastseg\\" + video + ".hdf5"
    h5paths.append(tempString)


# get all participant data sujign mihir
list_of_names = ["Mihir"] # put all participant names here
data_frames = []
count = 0
composited_indexes = []
indexVSObjects = vs_objects.copy()
for vs in vs_objects:
    tempLabels = []
    f2 = h5py.File(h5paths[vs_objects.index(vs)], "r")
    data = f2['labels'][:]
    allLabels.append(data)
    #vs.release()
    f2.close()
    print(h5paths[vs_objects.index(vs)])
print("finished allLabels creation")
print(*allLabels)
print(len(allLabels))

for name in list_of_names:
    count = 25
    for trial in range(1, 31):
        var_part_1 = name
        var_part_2 = "\Data"
        var_part_3 = str(trial)
        final_df_name = var_part_1 + var_part_2 + var_part_3

        path_part_1 = "C:\\Users\\krish\\Downloads\\Official Participant Data-20210918T182855Z-001\\Official Participant Data\\Adolescent\\Male\\"
        path_part_2 = final_df_name
        path_part_3 = ".csv"
        final_path_name = path_part_1 + path_part_2 + path_part_3
        if os.path.exists(final_path_name):
            data_frame = pb.read_csv(final_path_name)
            data_frames.append(data_frame)


    for vs in vs_objects:
        videoNumber = vs_objects.index(vs)
        total_frames = vs.get(cv2.CAP_PROP_FRAME_COUNT)
        fps = total_frames/25

        x_coordinates = data_frames[count]["Coordinate X"].tolist()
        length_x_1 = len(x_coordinates)
        x_coordinates = [x for x in x_coordinates if math.isnan(x) == False]
        length_x_2 = len(x_coordinates)
        x_coordinates = [round(x) for x in x_coordinates]
        y_coordinates = data_frames[count]["Coordinate Y"].tolist()
        y_coordinates = [y for y in y_coordinates if math.isnan(y) == False]
        y_coordinates = [round(y) for y in y_coordinates]

        num_of_na = length_x_1 - length_x_2
        nested_count = 0
        for x in x_coordinates:
            video_time = data_frames[count]["Decision Time (Updated)"][nested_count + num_of_na]
            print(videoNumber)
            #print(round(fps*video_time) - 1)
            fpsVal = round(fps*video_time) - 1
            if fpsVal >= int(total_frames):
                fpsVal = int(total_frames - 1)
            #print(total_frames)
            #print(type(fpsVal))
            #print(fpsVal)S
            #print(y_coordinates[nested_count])
            if x >= 1920:
                x = 1919
            yVal = y_coordinates[nested_count]
            if yVal >= 1080:
                yVal = 1079
            composited_index = allLabels[videoNumber][fpsVal][yVal][x]
            composited_indexes.append(composited_index)
            nested_count += 1

        for index in composited_indexes:
            i = composited_indexes.index(index)
            if (index == 0):
                composited_indexes[i] = "road"
            if (index == 1):
                composited_indexes[i] = "sidewalk"
            if (index == 2):
                composited_indexes[i] = "building"
            if (index == 3):
                composited_indexes[i] = "wall"
            if (index == 4):
                composited_indexes[i] = "fence"
            if (index == 5):
                composited_indexes[i] = "pole"
            if (index == 6):
                composited_indexes[i] = "traffic light"
            if (index == 7):
                composited_indexes[i] = "traffic sign"
            if (index == 8):
                composited_indexes[i] = "vegetation"
            if (index == 9):
                composited_indexes[i] = "terrain"
            if (index == 10):
                composited_indexes[i] = "sky"
            if (index == 11):
                composited_indexes[i] = "person"
            if (index == 12):
                composited_indexes[i] = "rider"
            if (index == 13):
                composited_indexes[i] = "car"
            if (index == 14):
                composited_indexes[i] = "truck"
            if (index == 15):
                composited_indexes[i] = "bus"
            if (index == 16):
                composited_indexes[i] = "train"
            if (index == 17):
                composited_indexes[i] = "motorcycle"
            if (index == 18):
                composited_indexes[i] = "bicycle"
        """
        data_frames[count]["Object Viewed"] = composited_indexes
        print(*composited_indexes)
        data_frames[count].to_csv(final_path_name, index=False)
        with open(final_path_name, "a") as filePath:
            wr = csv.writer(fp, dialect='excel')
        """
        var_part_1 = name
        var_part_2 = "\Data"
        var_part_3 = str(count+1)
        final_df_name = var_part_1 + var_part_2 + var_part_3

        path_part_1 = "C:\\Users\\krish\\Downloads\\Official Participant Data-20210918T182855Z-001\\Official Participant Data\\Adolescent\\Male\\"
        path_part_2 = final_df_name
        path_part_3 = ".csv"
        finalPath = path_part_1 + path_part_2 + path_part_3
        if os.path.exists(finalPath):
            df = pb.read_csv(finalPath)
            df['Object Viewed'] = composited_indexes
            df.to_csv(finalPath)

        #csv_file = pb.read_csv(final_path_name)
        #csv_file['Object Viewed Column'] = data_frames[count]["Object Viewed"]
        #csv_file.to_csv(final_path_name, index=False)

        count += 1
        #allLabels = []
        composited_indexes = []

    data_frames = []
