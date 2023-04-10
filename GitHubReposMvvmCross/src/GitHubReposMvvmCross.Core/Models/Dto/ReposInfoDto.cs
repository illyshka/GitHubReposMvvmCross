using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubReposMvvmCross.Core.Models.Dto
{

    public class ReposInfoDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string Full_name { get; set; }
      
        [JsonProperty("description")]
        public string Description { get; set; }        

        [JsonProperty("language")]
        public string Language { get; set; }        

        [JsonProperty("watchers")]
        public int Watchers { get; set; }

        [JsonProperty("default_branch")]
        public string Default_branch { get; set; }
    }
}
