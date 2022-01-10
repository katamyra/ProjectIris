import pandas as pb

list_of_names = ["Mohsen", "Dhananjay", "Aminghasem", "Hamid", "Ehsan", "Chetan", "Abhijeet", "Binay", "Santosh", "Venkata", "Krishnakanth", "Ashish",
"Biju", "Kyle", "Golgooneh", "Silvia", "Nona", "Shalizeh", "Neda", "Sudha", "Rinku", "Nausheen", "Batool", "Sumay", "Chaitanya",
"Shayan", "Satvik", "Satwik", "Lance", "Jay", "Daniel", "Mihir", "Jace", "Rohit", "Andy", "AdityaR", "AdityaG", "Alex", "Brendan", "Kenneth", "Yash", "Ilia",
"Atharv", "Eshwar", "Srijan", "Jeffrey", "Mehran", "Felix", "Sumukh", "Roksana", "Jace", "Zahra", "Kriti", "Noora", "Sam"]

list_of_trials = ["Data29", "Data16", "Data19", "Data7", "Data11", "Data20", "Data26", "Data18", "Data17"]
# list_of_videos = ["Video8.0", "Video10", "Video23", "Video28", "Video35", "Video44", "Video45", "Video46", "Video57""]

data_frames = []
sensitivities = []
sum_sensitivity = 0
mean_sensitivity = 0
viewed_object_indexes = []

for name in list_of_names:
    for trial in list_of_trials:
        path_part_1 = "C:\\Users\\krish\\Downloads\\Official Participant Data-20210918T182855Z-001\\Official Participant Data\\"
        path_part_2 = name
        path_part_3 = "\\"
        path_part_4 = trial
        path_part_5 = ".csv"
        final_path = path_part_1 + path_part_2 + path_part_3 + path_part_4 + path_part_5
        data_frame = pb.read_csv(final_path)
        data_frames.append(data_frame)

    # Video 8, Data 29, 0:13
    tentative_times = []
    times = data_frames[0]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[0]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 0.13 + 0.2) and (tentative_time >= 0.13 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 0.13))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    # Video 10, Data 16, 6:17
    tentative_times = []
    times = data_frames[1]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[1]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 6.17 + 0.2) and (tentative_time >= 6.17 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 6.17))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    # Video 23, Data 19, 2:19
    tentative_times = []
    times = data_frames[2]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[2]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 2.19 + 0.2) and (tentative_time >= 2.19 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 2.19))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    # Video 28, Data 7, 0:07
    tentative_times = []
    times = data_frames[3]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[3]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 0.07 + 0.2) and (tentative_time >= 0.07 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 0.07))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    # Video 28, Data 7, 6:16
    tentative_times = []
    times = data_frames[3]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[3]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 6.16 + 0.2) and (tentative_time >= 6.16 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 6.16))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    # Video 35, Data 11, 5:16
    tentative_times = []
    times = data_frames[4]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[4]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 5.16 + 0.2) and (tentative_time >= 5.16 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 5.16))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    # Video 44, Data 20, 5:00
    tentative_times = []
    times = data_frames[5]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[5]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 3.25 + 0.2) and (tentative_time >= 3.25 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 3.25))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    # Video 45, Data 26, 2.26
    tentative_times = []
    times = data_frames[6]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[6]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 2.26 + 0.2) and (tentative_time >= 2.26 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 2.26))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    # Video 46, Data 18, 5:00
    tentative_times = []
    times = data_frames[7]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[7]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 5.00 + 0.2) and (tentative_time >= 5.00 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 5.00))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    # Video 57, Data 17, 0:00
    tentative_times = []
    times = data_frames[8]["Decision Time (Updated)"].tolist()
    segmented_objects = data_frames[8]["Object Viewed"].tolist()
    for tentative_time in times:
        if ((tentative_time <= 0.00 + 0.2) and (tentative_time >= 0.00 - 0.2)):
            tentative_times.append(tentative_time)

    try:
        final_time = min(tentative_times, key=lambda x: abs(x - 0.00))
        index_of_time = times.index(final_time)

        if (segmented_objects[index_of_time] == "car" or segmented_objects[index_of_time] == "motorcycle" or
                segmented_objects[index_of_time] == "truck" or segmented_objects[index_of_time] == "bus" or
                segmented_objects[index_of_time] == "train"):
            pass
        else:
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "car"])
            viewed_object_indexes.append(
                [i for i in range(len(segmented_objects)) if segmented_objects[i] == "motorcycle"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "truck"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "bus"])
            viewed_object_indexes.append([i for i in range(len(segmented_objects)) if segmented_objects[i] == "train"])
            flattened_viewed_object_indexes = [j for sub in viewed_object_indexes for j in sub]
            flattened_viewed_object_indexes.sort()
            try:
                flattened_viewed_object_indexes = [i for i in flattened_viewed_object_indexes if i > index_of_time]
                index_of_next = flattened_viewed_object_indexes[0]
                sensitivity = times[index_of_next] - final_time
                if sensitivity > 2.5:
                    pass
                else:
                    sensitivities.append(sensitivity)
            except IndexError:
                pass
    except ValueError:
        pass
    viewed_object_indexes = []
    flattened_viewed_object_indexes = []


    try:
        for sensitivity in sensitivities:
            sum_sensitivity += sensitivity

        mean_sensitivity = (sum_sensitivity / len(sensitivities))
        print(name, mean_sensitivity)
    except ZeroDivisionError:
        print(name, "N/A")

    data_frames = []
    sum_sensitivity = 0