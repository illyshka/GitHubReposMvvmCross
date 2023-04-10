using GitHubReposMvvmCross.Core.Common;
using GitHubReposMvvmCross.Core.Models.Dto;
using GitHubReposMvvmCross.Core.Service.Interfaces;
using MvvmCross.ViewModels;
using Newtonsoft.Json;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GitHubReposMvvmCross.Core.Service
{
    public class GitHubService : IGitHubService
    {
        private HttpClient client;

        public GitHubService()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("mmaaaaaaaails");
        }
        

        public async Task<ObservableCollection<ReposInfoDto>> GetRepositoriesAsync()
        {
            try
            {
                var response = await client.GetStringAsync(Constants.ReposUrl);
                var result = JsonConvert.DeserializeObject<ObservableCollection<ReposInfoDto>>(response);
                return result;
            }
            catch (Exception ex)
            {

                return new ObservableCollection<ReposInfoDto>();
            }
        }

        public async Task<SearchResponseDto> GetSearchReposAsync(string query)
        {
            try
            {
                var response = await client.GetStringAsync(Constants.SearchReposUrl + query + "user:mmaaaaaaaails");
                var result = JsonConvert.DeserializeObject<SearchResponseDto>(response);
                return result;
            }
            catch (Exception ex)
            {

                return new SearchResponseDto();
            }
        }
    }
}
