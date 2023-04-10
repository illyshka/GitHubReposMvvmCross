using GitHubReposMvvmCross.Core.ViewModels.Home;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace GitHubReposMvvmCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
           .EndingWith("Service")
           .AsInterfaces()
           .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
