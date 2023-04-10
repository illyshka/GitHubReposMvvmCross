using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GitHubReposMvvmCross.Core.Models.Dto
{
    public class SearchResponseDto
    {
        public int Total_count { get; set; }
        public bool Incomplete_results { get; set; }
        public ObservableCollection<ReposInfoDto> Items { get; set; }
    }

}
