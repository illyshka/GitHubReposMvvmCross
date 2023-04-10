using Acr.UserDialogs;
using GitHubReposMvvmCross.Core.Common;
using GitHubReposMvvmCross.Core.Models.Dto;
using GitHubReposMvvmCross.Core.Service;
using GitHubReposMvvmCross.Core.Service.Interfaces;
using GitHubReposMvvmCross.Core.ViewModels.NavigationArgs;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using static MvvmCross.Binding.ExpressionParse.MvxParsedExpression;

namespace GitHubReposMvvmCross.Core.ViewModels.Home
{    
    public class HomeViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IGitHubService _gitHubService;
        public IMvxCommand OpenItemCommand => new MvxAsyncCommand<ReposInfoDto>(OpenItemExecute);
        public IMvxCommand SearchCommand => new MvxCommand(OnSearchExecute);

        public HomeViewModel(IMvxNavigationService navigationService, IGitHubService gitHubService)
        {
            _gitHubService = gitHubService;
            _navigationService = navigationService;            
            Task.Run(LoadData);
        }

        private async Task LoadData()
        {
            ActivityVisible = true;
            ReposItemsVisible = false; 

            var repositories = await _gitHubService.GetRepositoriesAsync();
            ReposItems = AllRepos = repositories;

            ActivityVisible = false;
            ReposItemsVisible = true;
        }
        public async Task OpenItemExecute(ReposInfoDto item)
        {
            var args = new RepInfoNavigationArgs(item);
            await _navigationService.Navigate<RepInfoViewModel, RepInfoNavigationArgs>(args);
        }

        private async void OnSearchExecute()
        {
            ActivityVisible = true;
            ReposItemsVisible = false;
            if (string.IsNullOrEmpty(QueryString))
            {
                ReposItems = AllRepos;                
            }
            else
            {
                string query = QueryString.ToLower();
                var search = await _gitHubService.GetSearchReposAsync(query);
                ReposItems = search?.Items;
            }

           
            ActivityVisible = false;
            ReposItemsVisible = true;
        }

        #region Init    
        public ObservableCollection<ReposInfoDto> AllRepos;

        private ObservableCollection<ReposInfoDto> reposItems;
        public ObservableCollection<ReposInfoDto> ReposItems
        {
            get => reposItems;
            set => SetProperty(ref reposItems, value, nameof(ReposItems));
        }

        private string queryString;
        public string QueryString
        {
            get => queryString;
            set
            {
                SetProperty(ref queryString, value, nameof(QueryString));
                OnSearchExecute();
            }
        }

        bool reposItemsVisible = true;
        public bool ReposItemsVisible
        {
            get => reposItemsVisible;
            set => SetProperty(ref reposItemsVisible, value, nameof(ReposItemsVisible));
        }
        #endregion
    }
}
