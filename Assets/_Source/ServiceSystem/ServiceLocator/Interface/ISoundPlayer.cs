namespace ServiceSystem.ServiceLocator.Interface
{
    interface ISoundPlayer : IGameService
    {
        public void PlayOpenSound();
        public void PlayCloseSound();
    }
}
