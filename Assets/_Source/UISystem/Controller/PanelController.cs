using System;
using ServiceSystem.ServiceLocator;
using ServiceSystem.ServiceLocator.Interface;
using UISystem.State;
using UnityEngine;
using UnityEngine.UI;
using Utils;
using Utils.Signal;
using Zenject;

namespace UISystem.Controller
{
    public class PanelController : IUIState
    {
        private readonly IFadeService _fadeService;
        private readonly ISoundPlayer _soundPlayer;
        private readonly Image _img;
        private readonly float _duration;
        
        private UISwitcher _uiSwitcher;

        [Inject]
        public PanelController(IFadeService fadeService, ISoundPlayer soundPlayer, Image img, float duration)
        {
            _fadeService = fadeService;
            _soundPlayer = soundPlayer;
            _img = img;
            _duration = duration;
        }

        public void GetSwitcher(UISwitcher switcher)
        {
            _uiSwitcher = switcher;
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
            _uiSwitcher.Switch(typeof(MainController));
        }
    }
}
