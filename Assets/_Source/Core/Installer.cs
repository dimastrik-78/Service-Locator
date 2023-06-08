using SaveSystem;
using ScoreSystem;
using ServiceSystem.ServiceLocator;
using ServiceSystem.ServiceLocator.Interface;
using UISystem;
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

        private UISwitcher _uiSwitcher;
        private FadeService _fadeService;
        private SoundPlayer _sound;

        public override void InstallBindings()
        {
            Container.Bind<IFadeService>()
                .To<FadeService>()
                .AsSingle()
                .NonLazy();
            Container.Bind<ISoundPlayer>()
                .To<SoundPlayer>()
                .AsSingle()
                .WithArguments(audioSource)
                .NonLazy();

            Container.Bind<IUIState>()
                .WithId(BuildID.MAIN_CONTROLLER)
                .To<MainController>()
                .AsCached()
                .WithArguments(img, duration)
                .NonLazy();
            Container.Bind<IUIState>()
                .WithId(BuildID.PANEL_CONTROLLER)
                .To<PanelController>()
                .AsCached()
                .WithArguments(img, duration)
                .NonLazy();

            Container.Bind<UISwitcher>()
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