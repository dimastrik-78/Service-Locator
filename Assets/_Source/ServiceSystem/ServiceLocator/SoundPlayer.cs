﻿using ServiceSystem.ServiceLocator.Interface;
using System;
using UnityEngine;

namespace ServiceSystem.ServiceLocator
{
    class SoundPlayer : ISoundPlayer
    {
        private AudioSource _audio;

        public SoundPlayer(AudioSource audio)
        {
            _audio = audio;
        }

        public void PlayCloseSound() =>
            _audio.Play();

        public void PlayOpenSound() =>
            _audio.Play();
    }
}
