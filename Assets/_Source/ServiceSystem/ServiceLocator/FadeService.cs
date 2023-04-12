﻿using ServiceSystem.ServiceLocator.Interface;
using UnityEngine.UI;

namespace ServiceSystem.ServiceLocator
{
    class FadeService : IFadeService
    {
        private const float _maxDuration = 1;
        private const float _minDuration = 0;

        public void FadeIn(Image img, float duration) =>
            Fade(img, _maxDuration, duration);

        public void FadeOut(Image img, float duration) =>
            Fade(img, _minDuration, duration);

        public void Fade(Image img, float endValue, float duration)
        {
            //img.DOFade(endValue, duration);
        }
    }
}
