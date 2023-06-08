using ServiceSystem.ServiceLocator.Interface;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceSystem.ServiceLocator
{
    class ServiceLocator : IService
    {
        private readonly Dictionary<Type, IGameService> _service = new();

        // public ServiceLocator(AudioSource audio)
        // {
        //     _service.Add(typeof(IFadeService), new FadeService());
        //     _service.Add(typeof(ISoundPlayer), new SoundPlayer(audio));
        // }
        
        public T GetService<T>()
        {
            return default;
        }

        public bool GetService<T>(out T service)
        {
            service = default;
            if (_service.ContainsKey(typeof(T)))
            {
                service = (T)_service[typeof(T)];
                return true;
            }

            return false;
        }
    }
}
