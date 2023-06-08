namespace UISystem.State
{
    public interface IUIState
    {
        void GetSwitcher(UISwitcher switcher);
        void Enter();
        void Exit();
    }
}
