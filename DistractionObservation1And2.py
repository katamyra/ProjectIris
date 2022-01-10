import os
import pandas as pd
import statistics
# Read data from file 'filename.csv'
# (in the same directory that your python process is based)
# Control delimiters, rows, column names with read_csv (see later)

from pathlib import Path

def runData(path):
    data = pd.read_csv(pathNew)
    timeData = data['Decision Time (Updated)']
    segmentedObject = data['Object Viewed']
    currentObject = segmentedObject.loc[1]
    timeForObject = timeData.loc[1]
    #print(timeForObject)
    #print(currentObject)

    for x in range(2, len(data.index)):
        if segmentedObject.loc[x] != currentObject:
            timeVal = timeData.loc[x - 1] - timeForObject
            if currentObject in distractions.keys():
                distractions[currentObject].append(timeVal)
            currentObject = segmentedObject.loc[x]
            timeForObject = timeData.loc[x]
    lowDistractions = ['sidewalk', 'traffic sign', 'traffic light', 'fence', 'wall']

    highDistractions = ['vegetation', 'sky', 'pole']
    totalLow = []
    totalHigh = []
    for key in distractions.keys():
        if key in lowDistractions:
            listVal = distractions[key]
            for element in listVal:
                totalLow.append(element)
        else:
            listVal = distractions[key]
            for element in listVal:
                totalHigh.append(element)
    if len(totalLow) > 0:
        allLow.append(statistics.mean(totalLow))
    if len(totalHigh) > 0:
        allHigh.append(statistics.mean(totalHigh))
distractions = {'Highway Border': [], 'sidewalk': [], 'traffic sign': [], 'fence': [], 'wall': [],
                'vegetation': [], 'sky': [], 'pole': []}
names = ["Satwik", "Mihir", "Sujith", "Andy"]
#path = "C:\\Users\\krish\\Downloads\\Official Participant Data-20210918T182855Z-001\\Official Participant Data\\Adolescent\\Male\\AdityaR\\Data"
p = Path()
for person in names:
    path = "C:\\Users\\krish\\Downloads\\Official Participant Data-20210918T182855Z-001\\Official Participant Data\\Adolescent\\Male\\" + person + "\\Data"
    allLow = []
    allHigh = []
    for x in range(1, 31):
        pathNew = path + str(x) + ".csv"
        #print(pathNew, os.path.isdir(pathNew))
        if os.path.exists(pathNew):
            runData(pathNew)
    print(person)
    print("Low: ", statistics.mean(allLow))
    print("High: ", statistics.mean(allHigh))
"""

import pandas as pd
import statistics
# Read data from file 'filename.csv'
# (in the same directory that your python process is based)
# Control delimiters, rows, column names with read_csv (see later)

def runData(path):
    data = pd.read_csv(pathNew)
    timeData = data['Decision Time (Updated)']
    segmentedObject = data['Object Viewed']
    currentObject = segmentedObject.loc[1]
    timeForObject = timeData.loc[1]
    #print(timeForObject)
    #print(currentObject)

    for x in range(2, len(data.index)):
        if segmentedObject.loc[x] != currentObject:
            timeVal = timeData.loc[x - 1] - timeForObject
            if currentObject in distractions.keys():
                distractions[currentObject].append(timeVal)
            currentObject = segmentedObject.loc[x]
            timeForObject = timeData.loc[x]
    lowDistractions = ['sidewalk', 'traffic sign', 'traffic light', 'fence', 'wall']

    highDistractions = ['vegetation', 'sky', 'pole']
    totalLow = []
    totalHigh = []
    for key in distractions.keys():
        if key in lowDistractions:
            listVal = distractions[key]
            for element in listVal:
                totalLow.append(element)
        else:
            listVal = distractions[key]
            for element in listVal:
                totalHigh.append(element)
    if len(totalLow) > 0:
        allLow.append(statistics.mean(totalLow))
    if len(totalHigh) > 0:
        allHigh.append(statistics.mean(totalHigh))
distractions = {'Highway Border': [], 'sidewalk': [], 'traffic sign': [], 'fence': [], 'wall': [],
                'vegetatioSn': [], 'sky': [], 'pole': []}
names = ["Shayan", "Srijan", "Sujith", "Sumay", "Sumukh", "Yash"]
#path = "C:\\Users\\krish\\Downloads\\Official Participant Data-20210918T182855Z-001\\Official Participant Data\\Adolescent\\Male\\AdityaR\\Data"

for person in names:
    path = "C:\\Users\\krish\\Downloads\\Official Participant Data-20210918T182855Z-001\\Official Participant Data\\Adolescent\\Male\\" + person + "\\Data"
    allLow = []
    allHigh = []
    totalTime = 0
    for x in range(1, 31):
        pathNew = path + str(x) + ".csv"
        if os.path.exists(pathNew):
            runData(pathNew)
            data = pd.read_csv(pathNew)
            decisionFinal = data["Decision Time (Final)"]
            totalTime += decisionFinal.iloc[-1]
            #print(totalTime)

    print(person)
    print("Low: ", sum(allLow)/totalTime)
    print("High: ", sum(allHigh)/totalTime)
"""
