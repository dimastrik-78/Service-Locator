using System;
using ServiceSystem.ServiceLocator;
using UISystem.State;
using UnityEngine;
using UnityEngine.UI;
using Utils;
using Utils.Signal;

namespace UISystem.Controller
{
    public class PanelController : IUIState
    {
        private readonly UISwitcher _uiSwitcher;
        private readonly FadeService _fadeService;
        private readonly SoundPlayer _soundPlayer;
        private readonly Image _img;
        private readonly float _duration;

        public PanelController(UISwitcher uiSwitcher, FadeService fadeService, SoundPlayer soundPlayer, Image img, float duration)
        {
            _uiSwitcher = uiSwitcher;
            _fadeService = fadeService;
            _soundPlayer = soundPlayer;
            _img = img;
            _duration = duration;
        }
        
        public void Enter()
        {
            Signals.Get<SwitchPanelState>().AddListener(Switch);
        }
        
        public void Exit()
        {
            Signals.Get<SwitchPanelState>().RemoveListener(Switch);
        }

        private void Switch()
        {
            _fadeService.FadeOut(_img, _duration);
            _soundPlayer.PlayCloseSound();
            _uiSwitcher.Switch(0);
        }
    }
}
