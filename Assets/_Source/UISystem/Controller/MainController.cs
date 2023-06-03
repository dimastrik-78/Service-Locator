using System;
using ServiceSystem.ServiceLocator;
using UISystem.State;
using UnityEngine;
using UnityEngine.UI;
using Utils;
using Utils.Signal;

namespace UISystem.Controller
{
    public class MainController : IUIState
    {
        private readonly UISwitcher _uiSwitcher;
        private readonly FadeService _fadeService;
        private readonly SoundPlayer _soundPlayer;
        private readonly Image _img;
        private readonly float _duration;

        public MainController(UISwitcher uiSwitcher, FadeService fadeService, SoundPlayer soundPlayer, Image img, float duration)
        {
            _uiSwitcher = uiSwitcher;
            _fadeService = fadeService;
            _soundPlayer = soundPlayer;
            _img = img;
            _duration = duration;
        }
        
        public void Enter()
        {
            Signals.Get<SwitchMainState>().AddListener(Switch);
        }

        public void Exit()
        {
            Signals.Get<SwitchMainState>().RemoveListener(Switch);
        }
        
        private void Switch()
        {
            _fadeService.FadeIn(_img, _duration);
            _soundPlayer.PlayOpenSound();
            _uiSwitcher.Switch(typeof(PanelController));
        }
    }
}
