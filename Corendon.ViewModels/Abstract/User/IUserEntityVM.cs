namespace Corendon.ViewModels.Abstract.User
{
    public interface IUserEntityVM
    {
        void SetJWT(string jwt);
        IUserEntityVM GetInstance();
    }
}
