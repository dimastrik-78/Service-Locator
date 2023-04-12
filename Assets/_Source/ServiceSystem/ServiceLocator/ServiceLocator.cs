using Assets._Source.ServiceSystem.ServiceLocator.Interface;
using ServiceSystem.ServiceLocator.Interface;
using System;
using System.Collections.Generic;

namespace ServiceSystem.ServiceLocator
{
    class ServiceLocator : IService
    {
        private Dictionary<Type, IGameService> _service;

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
