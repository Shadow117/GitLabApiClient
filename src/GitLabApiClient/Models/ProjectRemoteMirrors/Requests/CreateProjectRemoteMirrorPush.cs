using GitLabApiClient.Internal.Utilities;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.ProjectRemoteMirrors.Requests
{
    public class CreateProjectRemoteMirrorPush
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRemoteMirrorPush"/> class.
        /// </summary>
        /// <param name="url">Remote url.</param>
        public CreateProjectRemoteMirrorPush(string url)
        {
            Guard.NotEmpty(url, nameof(url));
            Url = url;
        }

        /// <summary>
        /// The remote url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; private set; }

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
