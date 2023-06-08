using System;
using ServiceSystem.ServiceLocator;
using ServiceSystem.ServiceLocator.Interface;
using UISystem.State;
using UnityEngine.UI;
using Utils;
using Utils.Signal;
using Zenject;

namespace UISystem.Controller
{
    public class MainController : IUIState
    {
        private readonly IFadeService _fadeService;
        private readonly ISoundPlayer _soundPlayer;
        private readonly Image _img;
        private readonly float _duration;
        
        private UISwitcher _uiSwitcher;
        
        [Inject]
        public MainController(IFadeService fadeService, ISoundPlayer soundPlayer, Image img, float duration)
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
