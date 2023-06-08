using System.IO;
using UnityEngine;

namespace SaveSystem
{
    public class JsonSave : ISaver
    {
        private const string SAVE_PATH = "/Data.json";
        
        public void SaveScore(int score, string path = null)
        {
            string data = JsonUtility.ToJson(new ScoreData(score));
            File.WriteAllText(Application.persistentDataPath + SAVE_PATH, data);
            File.WriteAllText(Application.dataPath + SAVE_PATH, data);
        }
    }
}