using UnityEngine;

namespace SaveSystem
{
    public class PlayerPrefsSave : ISaver
    {
        public void SaveScore(int score, string path = null)
        {
            PlayerPrefs.SetInt("ScoreData", score);
            PlayerPrefs.Save();
        }
    }
}