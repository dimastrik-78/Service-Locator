namespace ServiceSystem.ServiceLocator.Interface
{
    interface IService
    {
        T GetService<T>();
    }
}
