using GitHubReposMvvmCross.Core.Service;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using GitHubReposMvvmCross.Core.ViewModels.NavigationArgs;

namespace GitHubReposMvvmCross.Core.ViewModels
{
    public class RepInfoViewModel : MvxViewModel<RepInfoNavigationArgs>
    {
        #region Init 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int Watchers { get; set; }

        #endregion

        public RepInfoViewModel(){}
        
        public override void Prepare(RepInfoNavigationArgs args)
        {
            Name = args.Name;
            Description = args.Description;
            Language = args.Language;
            Watchers = args.Watchers;
        }
    }
}
