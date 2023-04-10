using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubReposMvvmCross.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        bool _activityVisible;

        public BaseViewModel()
        {
            
        }

        public bool ActivityVisible
        {
            get => _activityVisible;
            set => SetProperty(ref _activityVisible, value, nameof(ActivityVisible));            
        }
    }
}
