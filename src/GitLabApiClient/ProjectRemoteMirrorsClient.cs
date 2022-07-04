using System.Collections.Generic;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models.ProjectRemoteMirrors.Requests;
using GitLabApiClient.Models.ProjectRemoteMirrors.Responses;

namespace GitLabApiClient
{
    public class ProjectRemoteMirrorsClient : IProjectRemoteMirrorsClient
    {
        private readonly GitLabHttpFacade _httpFacade;

        internal ProjectRemoteMirrorsClient(GitLabHttpFacade httpFacade) => _httpFacade = httpFacade;

        public async Task<IList<ProjectRemoteMirror>> GetAsync(ProjectId projectId)
        {
            return await _httpFacade.Get<IList<ProjectRemoteMirror>>($"projects/{projectId}/remote_mirrors");
        }

        public async Task<ProjectRemoteMirror> GetAsync(ProjectId projectId, int projectRemoteMirrorId)
        {
            return await _httpFacade.Get<ProjectRemoteMirror>(
                $"projects/{projectId}/remote_mirrors/{projectRemoteMirrorId}"
            );
        }

        public async Task<ProjectRemoteMirror> CreateProjectRemoteMirrorPushAsync(
            ProjectId projectId,
            CreateProjectRemoteMirrorPush request
        )
        {
            Guard.NotNull(request, nameof(request));
            return await _httpFacade.Post<ProjectRemoteMirror>($"projects/{projectId}/remote_mirrors", request);
        }

        public async Task<ProjectRemoteMirror> UpdateProjectRemoteMirrorPushAsync(
            ProjectId projectId,
            int projectRemoteMirrorId,
            UpdateProjectRemoteMirrorPush request
        )
        {
            Guard.NotNull(request, nameof(request));
            return await _httpFacade.Put<ProjectRemoteMirror>(
                $"projects/{projectId}/remote_mirrors/{projectRemoteMirrorId}",
                request
            );
        }

        public async Task<ProjectRemoteMirror> CreateProjectRemoteMirrorPullAsync(
            ProjectId projectId,
            CreateProjectRemoteMirrorPull request
        )
        {
            Guard.NotNull(request, nameof(request));
            return await _httpFacade.Post<ProjectRemoteMirror>($"projects/{projectId}/remote_mirrors", request);
        }

        public async Task<ProjectRemoteMirror> UpdateProjectRemoteMirrorPullAsync(
            ProjectId projectId,
            int projectRemoteMirrorId,
            UpdateProjectRemoteMirrorPull request
        )
        {
            Guard.NotNull(request, nameof(request));
            return await _httpFacade.Put<ProjectRemoteMirror>(
                $"projects/{projectId}/remote_mirrors/{projectRemoteMirrorId}",
                request
            );
        }

        public async Task DeleteAsync(ProjectId projectId, int projectRemoteMirrorId)
        {
            await _httpFacade.Delete($"projects/{projectId}/remote_mirrors/{projectRemoteMirrorId}");
        }
    }
}
