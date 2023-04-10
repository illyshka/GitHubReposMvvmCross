using GitHubReposMvvmCross.Core.Models.Dto;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace GitHubReposMvvmCross.Core.Service.Interfaces
{
    public interface IGitHubService
    {
        Task<ObservableCollection<ReposInfoDto>> GetRepositoriesAsync();
        Task<SearchResponseDto> GetSearchReposAsync(string query);
    }
}
