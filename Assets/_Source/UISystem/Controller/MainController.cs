using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using Utils.Signal;

public class MainController : IUIState
{
    public void Enter()
    {
        Signals.Get<SwithController>().AddListener(Switch);
    }

    private void Switch(GameObject gameObject)
    {

    }

    public void Exit()
    {
        Signals.Get<SwithController>().RemoveListener(Switch);
    }
}
