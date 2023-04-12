using Utils;
using Utils.Signal;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : IUIState
{
    //UISwitcher switcher
    public void Enter()
    {
        Signals.Get<SwithController>().AddListener(Switch);
    }

    private void Switch(GameObject gameObject)
    {
        gameObject.active = true;
    }

    public void Exit()
    {
        Signals.Get<SwithController>().RemoveListener(Switch);
    }
}
