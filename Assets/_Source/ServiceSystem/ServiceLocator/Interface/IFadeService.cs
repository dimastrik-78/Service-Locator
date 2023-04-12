using UnityEngine.UI;

namespace ServiceSystem.ServiceLocator.Interface
{
    interface IFadeService
    {
        public void FadeIn(Image img, float duration);
        public void FadeOut(Image img, float duration);
    }
}
