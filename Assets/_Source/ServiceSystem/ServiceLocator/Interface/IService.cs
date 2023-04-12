using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.ServiceLocator.Interface
{
    interface IService
    {
        public T GetService<T>();
    }
}
