namespace Corendon.ViewModels.Abstract.User
{
    public interface IUserEntityModel
    {
        void SetJWT(string jwt);
        IUserEntityModel GetInstance();
    }
}
