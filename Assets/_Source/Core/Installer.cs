using SaveSystem;
using ScoreSystem;
using ServiceSystem.ServiceLocator;
using ServiceSystem.ServiceLocator.Interface;
using UISystem.Controller;
using UISystem.State;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Core
{
    public class Installer : MonoInstaller
    {
        [SerializeField] private Image img;
        [SerializeField] private float duration;
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private Text scoreText;
        [SerializeField] private Button scoreButton;
        
        public override void InstallBindings()
        {
            Container.Bind<IGameService>()
                .To<FadeService>()
                .AsSingle()
                .NonLazy();
            Container.Bind<IGameService>()
                .To<SoundPlayer>()
                .AsSingle()
                .NonLazy();

            Container.Bind<IUIState>()
                .WithId(BuildID.MAIN_CONTROLLER)
                .To<MainController>()
                .AsSingle()
                .NonLazy();
            Container.Bind<IUIState>()
                .WithId(BuildID.PANEL_CONTROLLER)
                .To<MainController>()
                .AsSingle()
                .NonLazy();

            Container.Bind<Score>()
                .AsSingle();

            //Container.Bind<ISaver>().To<JsonSave>().AsSingle();
            Container.Bind<ISaver>()
                .To<PlayerPrefsSave>()
                .AsSingle();
        }
    }

    public static class BuildID
    {
        public const int MAIN_CONTROLLER = 0;
        public const int PANEL_CONTROLLER = 1;
    }
}