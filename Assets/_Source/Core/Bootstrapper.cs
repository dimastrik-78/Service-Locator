using ServiceSystem.ServiceLocator;
using System.Collections.Generic;
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
        
        private ServiceLocator _serviceLocator;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            UISwitcher uiSwitcher = new UISwitcher();
            
            _serviceLocator = new ServiceLocator(audioSource);
            if (!_serviceLocator.GetService(out FadeService fadeService)) return;
            if (!_serviceLocator.GetService(out SoundPlayer soundPlayer)) return;
            Dictionary<int, IUIState> states = new() 
            {
                { 0, new MainController(uiSwitcher, fadeService, soundPlayer, img, duration) },
                { 1, new PanelController(uiSwitcher, fadeService, soundPlayer, img, duration) }
            };

            uiSwitcher.SetDictionary(states);
            uiSwitcher.Switch(0);
        }
    }
}
