using GitLabApiClient.Internal.Utilities;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.ProjectRemoteMirrors.Requests
{
    public class CreateProjectRemoteMirrorPull
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRemoteMirrorPush"/> class.
        /// </summary>
        /// <param name="importUrl">Remote url.</param>
        public CreateProjectRemoteMirrorPull(string importUrl)
        {
            Guard.NotEmpty(importUrl, nameof(importUrl));
            ImportImportUrl = importUrl;
        }

        /// <summary>
        /// The remote url.
        /// </summary>
        [JsonProperty("import_url")]
        public string ImportImportUrl { get; private set; }

        /// <summary>
        /// The flag that indicates if the mirror is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// The flag that indicates if is to mirror only protected branches
        /// </summary>
        [JsonProperty("only_protected_branches")]
        public bool? OnlyProtectedBranches { get; set; } = false;

        /// <summary>
        /// The flag that indicates if the divergent refs are to be kept
        /// </summary>
        [JsonProperty("keep_divergent_refs")]
        public bool? KeepDivergentRefs { get; set; } = false;
    }
}
