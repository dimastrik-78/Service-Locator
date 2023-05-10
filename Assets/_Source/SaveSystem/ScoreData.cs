using System;

namespace SaveSystem
{
    [Serializable]
    public class ScoreData
    {
        public int Score;

        public ScoreData(int score)
        {
            Score = score;
        }
    }
}