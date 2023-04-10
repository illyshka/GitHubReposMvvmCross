using GitHubReposMvvmCross.Core.Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubReposMvvmCross.Core.ViewModels.NavigationArgs
{
    public class RepInfoNavigationArgs
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int Watchers { get; set; }

        public RepInfoNavigationArgs(ReposInfoDto dto)
        {
            Name = dto.Name;
            Description = dto.Description;
            Language = dto.Language;
            Watchers = dto.Watchers;
        }

        
    }
}
