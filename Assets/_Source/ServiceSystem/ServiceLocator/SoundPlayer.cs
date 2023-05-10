using ServiceSystem.ServiceLocator.Interface;
using UnityEngine;

namespace ServiceSystem.ServiceLocator
{
    public class SoundPlayer : ISoundPlayer
    {
        private readonly AudioSource _audio;

        public SoundPlayer(AudioSource audio)
        {
            _audio = audio;
        }

        public void PlayCloseSound() =>
            Debug.Log("Close sound");

        public void PlayOpenSound() =>
            Debug.Log("Open sound");
    }
}
