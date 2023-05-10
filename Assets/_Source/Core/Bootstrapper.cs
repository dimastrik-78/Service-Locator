using ServiceSystem.ServiceLocator;
using System.Collections.Generic;
using ScoreSystem;
using ServiceSystem.ServiceLocator.Interface;
using UISystem;
using UISystem.Controller;
using UISystem.State;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Image img;
        [SerializeField] private float duration;
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private Text scoreText;
        [SerializeField] private Button scoreButton;
        
        private ServiceLocator _serviceLocator;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            UISwitcher uiSwitcher = new UISwitcher();
            
            _serviceLocator = new ServiceLocator(audioSource);
            if (!_serviceLocator.GetService(out IFadeService fadeService)) return;
            if (!_serviceLocator.GetService(out ISoundPlayer soundPlayer)) return;
            Dictionary<int, IUIState> states = new() 
            {
                { 0, new MainController(uiSwitcher, (FadeService)fadeService, (SoundPlayer)soundPlayer, img, duration) },
                { 1, new PanelController(uiSwitcher, (FadeService)fadeService, (SoundPlayer)soundPlayer, img, duration) }
            };

            uiSwitcher.SetDictionary(states);
            uiSwitcher.Switch(0);
            
            new Score(scoreText, scoreButton);
        }
    }
}
