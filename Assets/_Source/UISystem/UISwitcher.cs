using System;
using System.Collections.Generic;
using Core;
using UISystem.Controller;
using UISystem.State;
using UnityEngine;
using Zenject;

namespace UISystem
{
    public class UISwitcher
    {
        private Dictionary<Type, IUIState> _states;
        private IUIState _state;

        [Inject]
        public UISwitcher([Inject(Id = BuildID.MAIN_CONTROLLER)] IUIState mainController,
            [Inject(Id = BuildID.PANEL_CONTROLLER)] IUIState panelController)
        {
            _states = new Dictionary<Type, IUIState>
            {
                { typeof(MainController), mainController },
                { typeof(PanelController), panelController }
            };
            
            Switch(typeof(MainController));
        }

        public void Switch(Type type)
        {
            _state?.Exit();
            _state = _states[type];
            _state.Enter();
        }
    }
}
