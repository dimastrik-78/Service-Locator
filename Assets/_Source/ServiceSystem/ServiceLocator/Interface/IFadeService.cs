using System;
using UnityEngine.UI;

namespace ServiceSystem.ServiceLocator.Interface
{
    interface IFadeService
    {
        public void FadeIn(Image img, float duration, Action action);
        public void FadeOut(Image img, float duration, Action action);
    }
}
