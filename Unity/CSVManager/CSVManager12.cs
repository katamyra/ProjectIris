using UnityEngine;
using System.IO;

public static class CSVManager12
{

    private static string reportDirectoryName = "DataFiles";
    private static string reportFileName = "Data12.csv";
    private static string reportSeparator = ",";
    private static string[] reportHeaders = new string[20] {
        "Trial #",
        "Lane Change",
        "Name",
        "Participant #",
        "Age",
        "Sex",
        "Handedness",
        "Experience",
        "Rank",
        "Disorder",
        "Decision Time (Updated)",
        "Decision Time (Final)",
        "Coordinate X",
        "Coordinate Y",
        "Head Position X",
        "Head Position Y",
        "Head Position Z",
        "Head Rotation X",
        "Head Rotation Y",
        "Head Rotation Z"
    };
    private static string timeStampHeader = "Time Stamp";

    #region Interactions

    public static void AppendToReport(string[] strings)
    {
        VerifyDirectory();
        VerifyFile();
        using (StreamWriter sw = File.AppendText(GetFilePath()))
        {
            string finalString = "";
            for (int i = 0; i < strings.Length; i++)
            {
                if (finalString != "")
                {
                    finalString += reportSeparator;
                }
                finalString += strings[i];
            }
            finalString += reportSeparator + GetTimeStamp();
            sw.WriteLine(finalString);
        }
    }

    public static void CreateReport()
    {
        VerifyDirectory();
        using (StreamWriter sw = File.CreateText(GetFilePath()))
        {
            string finalString = "";
            for (int i = 0; i < reportHeaders.Length; i++)
            {
                if (finalString != "")
                {
                    finalString += reportSeparator;
                }
                finalString += reportHeaders[i];
            }
            finalString += reportSeparator + timeStampHeader;
            sw.WriteLine(finalString);
        }
    }

    #endregion


    #region Operations

    static void VerifyDirectory()
    {
        string dir = GetDirectoryPath();
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
    }

    static void VerifyFile()
    {
        string file = GetFilePath();
        if (!File.Exists(file))
        {
            CreateReport();
        }
    }

    #endregion


    #region Queries

    static string GetDirectoryPath()
    {
        return Application.dataPath + "/" + reportDirectoryName;
    }

    static string GetFilePath()
    {
        return GetDirectoryPath() + "/" + reportFileName;
    }

    static string GetTimeStamp()
    {
        return System.DateTime.Now.ToString();
    }

    #endregion

}