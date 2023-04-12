using ServiceSystem.ServiceLocator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.ServiceLocator
{
    class ServiceLocator : IService
    {
        public T GetService<T>()
        {
            return default;
        }
    }
}
