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
        private ServiceLocator _serviceLocator;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            // _serviceLocator = new ServiceLocator(audioSource);
        }
    }
}
