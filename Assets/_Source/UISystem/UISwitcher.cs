using System;
using System.Collections.Generic;
using UISystem.Controller;
using UISystem.State;
using UnityEngine;

namespace UISystem
{
    public class UISwitcher
    {
        private Dictionary<int, IUIState> _states;
        private IUIState _state;

        public void SetDictionary(Dictionary<int, IUIState> states)
        {
            _states = states;
        }
        
        public void Switch(int id)
        {
            _state?.Exit();
            _state = _states[id];
            _state.Enter();
        }
    }
}
