using DG.Tweening;
using System;
using ServiceSystem.ServiceLocator.Interface;
using UnityEngine.UI;

namespace ServiceSystem.ServiceLocator
{
    class FadeService : IFadeService
    {
        private const float _maxDuration = 1;
        private const float _minDuration = 0;

        public void FadeIn(Image img, float duration, Action action) =>
            Fade(img, _maxDuration, duration, action);

        public void FadeOut(Image img, float duration, Action action) =>
            Fade(img, _minDuration, duration, action);

        public void Fade(Image img, float endValue, float duration, Action action)
        {
            img.DOFade(endValue, duration)
                .OnComplete(() =>
                {
                    action?.Invoke();
                });
        }
    }
}
