using UnityEngine.UI;
using Utils;
using Utils.Signal;
using SaveSystem;

namespace ScoreSystem
{
    public class Score
    {
        private readonly Text _scoreText;
        private readonly Button _scoreButton;

        private PlayerPrefsSave _playerPrefsSave;
        private int _score;

        public Score(Text scoreText, Button scoreButton)
        {
            _scoreText = scoreText;
            _scoreButton = scoreButton;

            Init();
        }

        private void Init()
        {
            _playerPrefsSave = new PlayerPrefsSave();

            OnEnable();
            ScoreUpdate(_score);
        }
        
        private void OnEnable()
        {
            _scoreButton.onClick.AddListener(AddScore);
            Signals.Get<SwitchPanelState>().AddListener(OnDisable);
            Signals.Get<SwitchPanelState>().RemoveListener(OnEnable);
        }

        private void OnDisable()
        {
            _playerPrefsSave.SaveScore(_score);
            _scoreButton.onClick.RemoveListener(AddScore);
            Signals.Get<SwitchPanelState>().AddListener(OnEnable);
            Signals.Get<SwitchPanelState>().RemoveListener(OnDisable);
        }

        private void AddScore()
        {
            _score++;
            ScoreUpdate(_score);
        }

        private void ScoreUpdate(int score) =>
            _scoreText.text = score.ToString();
    }
}