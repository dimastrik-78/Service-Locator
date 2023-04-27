using DG.Tweening;
using System;
using ServiceSystem.ServiceLocator.Interface;
using UnityEngine;
using UnityEngine.UI;
using Utils;
using Utils.Signal;

namespace ServiceSystem.ServiceLocator
{
    public class FadeService : IFadeService
    {
        private const float MAX_DURATION = 1;
        private const float MIN_DURATION = 0;

        public void FadeIn(Image img, float duration) =>
            Fade(img, MAX_DURATION, duration);

        public void FadeOut(Image img, float duration) =>
            Fade(img, MIN_DURATION, duration);

        private void Fade(Image img, float endValue, float duration)
        {
            img.DOFade(endValue, duration)
                .OnComplete(() =>
                {
                    Signals.Get<ChangePanelUI>().Dispatch();
                });
            Signals.Get<ChangePanelUI>().Dispatch();
        }
    }
}
