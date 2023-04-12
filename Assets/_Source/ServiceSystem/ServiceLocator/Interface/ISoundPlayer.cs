using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSystem.ServiceLocator.Interface
{
    interface ISoundPlayer
    {
        public void PlayOpenSound();
        public void PlayCloseSound();
    }
}
