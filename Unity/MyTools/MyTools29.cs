using UnityEngine;
using Tobii.Gaming;

namespace Data
{
    public static class MyTools29
    {
        private static string Name;
        private static string Participant;
        private static string Age;
        private static string Sex;
        private static string Handedness;
        private static string Experience;
        private static string Rank;
        private static string Disorder;
        private static string trial;
        private static string lane;
        private static string finaltime;
        private static string updatedtime;

        public static void DEV_AppendDefaultsToReport()
        {
            trial = "Trial 29";
            lane = "Left";

            Name = PlayerPrefs.GetString("Name");
            Participant = PlayerPrefs.GetString("Participant");
            Age = PlayerPrefs.GetString("Age");
            Sex = PlayerPrefs.GetString("Sex");
            Handedness = PlayerPrefs.GetString("Handedness");
            Experience = PlayerPrefs.GetString("Driving");
            Rank = PlayerPrefs.GetString("Rank");
            Disorder = PlayerPrefs.GetString("Disorder");

            updatedtime = PlayerPrefs.GetString("ReactionTime29U");
            finaltime = PlayerPrefs.GetString("ReactionTime29F");
            GazePoint gazePoint = TobiiAPI.GetGazePoint();
            HeadPose headPose = TobiiAPI.GetHeadPose();

            CSVManager29.AppendToReport(
                    new string[20] {
                trial,
                lane,
                Name,
                Participant,
                Age,
                Sex,
                Handedness,
                Experience,
                Rank,
                Disorder,
                updatedtime,
                finaltime,
                gazePoint.Screen.x.ToString(),
                gazePoint.Screen.y.ToString(),
                headPose.Position.x.ToString(),
                headPose.Position.y.ToString(),
                headPose.Position.z.ToString(),
                headPose.Rotation.eulerAngles.x.ToString(),
                headPose.Rotation.eulerAngles.y.ToString(),
                headPose.Rotation.eulerAngles.z.ToString()
                    }
                );
        }
    }
}
