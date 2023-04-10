using Microsoft.Extensions.Logging;
using MvvmCross.Forms.Platforms.Ios.Core;

namespace GitHubReposMvvmCross.iOS
{
    public class Setup : MvxFormsIosSetup<Core.App, UI.App>
    {
        protected override ILoggerFactory CreateLogFactory() => null;
        protected override ILoggerProvider CreateLogProvider() => null;
    }
}
