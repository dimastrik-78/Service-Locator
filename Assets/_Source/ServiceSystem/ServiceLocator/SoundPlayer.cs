using ServiceSystem.ServiceLocator.Interface;
using UnityEngine;
using Zenject;

namespace ServiceSystem.ServiceLocator
{
    public class SoundPlayer : ISoundPlayer
    {
        private readonly AudioSource _audio;

        [Inject]
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
