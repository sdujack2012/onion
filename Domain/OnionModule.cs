using Domain.Interfaces;
using Ninject.Modules;
using Repositories;
using Service;
using ServiceInterfaces;

namespace Main
{
    public class OnionModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUserRepository>().To<UserRepository>();
            this.Bind<IUserService>().To<UserService>();
        }
    }
}
