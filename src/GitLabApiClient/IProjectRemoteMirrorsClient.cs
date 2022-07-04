using System.Collections.Generic;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.ProjectRemoteMirrors.Requests;
using GitLabApiClient.Models.ProjectRemoteMirrors.Responses;
using GitLabApiClient.Models.Projects.Responses;

namespace GitLabApiClient
{
    public interface IProjectRemoteMirrorsClient
    {

        /// <summary>
        /// Retrieves all project remote mirrors found in the specific project.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        Task<IList<ProjectRemoteMirror>> GetAsync(ProjectId projectId);

        /// <summary>
        /// Retrieves the single project remote mirror by its id
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="projectRemoteMirrorId">The project remote mirror id.</param>
        Task<ProjectRemoteMirror> GetAsync(ProjectId projectId, int projectRemoteMirrorId);

        /// <summary>
        /// Creates project remote mirror.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="request">Create project remote mirror request.</param>
        /// <param name="pull">Flag that indicates the direction of the remote mirror.</param>
        /// <returns>Newly created project remote mirror.</returns>
        Task<ProjectRemoteMirror> CreateProjectRemoteMirrorPushAsync(ProjectId projectId, CreateProjectRemoteMirrorPush request);

        /// <summary>
        /// Updates existing project remote mirror.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="projectRemoteMirrorId">Id of the project remote mirror.</param>
        /// <param name="request">Update project request.</param>
        /// <returns>Newly modified project.</returns>
        Task<ProjectRemoteMirror> UpdateProjectRemoteMirrorPushAsync(ProjectId projectId, int projectRemoteMirrorId, UpdateProjectRemoteMirrorPush request);

        /// <summary>
        /// Creates project remote mirror.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="request">Create project remote mirror request.</param>
        /// <param name="pull">Flag that indicates the direction of the remote mirror.</param>
        /// <returns>Newly created project remote mirror.</returns>
        Task<ProjectRemoteMirror> CreateProjectRemoteMirrorPullAsync(ProjectId projectId, CreateProjectRemoteMirrorPull request);

        /// <summary>
        /// Updates existing project remote mirror.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="projectRemoteMirrorId">Id of the project remote mirror.</param>
        /// <param name="request">Update project request.</param>
        /// <returns>Newly modified project.</returns>
        Task<ProjectRemoteMirror> UpdateProjectRemoteMirrorPullAsync(ProjectId projectId, int projectRemoteMirrorId, UpdateProjectRemoteMirrorPull request);
        /// <summary>
        /// Deletes project remote mirror.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="projectRemoteMirrorId">Id of the project remote mirror.</param>
        Task DeleteAsync(ProjectId projectId, int projectRemoteMirrorId);
    }
}
