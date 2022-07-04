using System;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.ProjectRemoteMirrors.Responses
{
    public class ProjectRemoteMirror
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("last_successful_update_at")]
        public DateTime? LastSuccessfulUpdateAt { get; set; }

        [JsonProperty("last_update_at")]
        public DateTime? LastUpdateAt { get; set; }

        [JsonProperty("last_update_started_at")]
        public DateTime? LastUpdateStartedAt { get; set; }

        [JsonProperty("only_protected_branches")]
        public bool OnlyProtectedBranches { get; set; }

        [JsonProperty("keep_divergent_refs")]
        public bool KeepDivergentRefs { get; set; }

        [JsonProperty("update_status")]
        public string UpdateStatus { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

    }
}
