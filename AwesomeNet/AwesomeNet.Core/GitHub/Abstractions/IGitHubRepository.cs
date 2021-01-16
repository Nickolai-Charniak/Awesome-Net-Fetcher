using System.Threading.Tasks;
using AwesomeNet.Core.GitHub.Common;

namespace AwesomeNet.Core.GitHub.Abstractions
{
    /// <summary>
    /// Represent any GitHub repo which can be fetched from GitHub API
    /// Should be interpret as abstraction of point by which can be fetch info about repo
    /// </summary>
    public interface IGitHubRepository
    {
        
        /// <summary>
        /// GitHub Repo Owner. With GitHub Repo name forms unique GitHub repo url as owner/name
        /// </summary>
        string Owner { get; }
        /// <summary>
        /// GitHub Repo Name. With GitHub Repo owner forms unique GitHub repo url as owner/name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Get standard info about current repository
        /// </summary>
        /// <returns></returns>
        Task<GitHubRepositoryInfo> GetRepositoryInfoAsync();
        
        /// <summary>
        /// Get file by name from root of GitHub repository
        /// </summary>
        /// <param name="fileName">Name of file. Extensions must be provided too</param>
        /// <returns type="GitHubFile"></returns>
        Task<GitHubFile> GetFileFromRootAsync(string fileName);
        
        /// <summary>
        /// Get file from GitHub repository by specific its path and name 
        /// </summary>
        /// <param name="path">Path of file location</param>
        /// <param name="fileName">Name of file. Extensions must be provided too</param>
        /// <returns></returns>
        Task<GitHubFile> GetFileAsync(string path, string fileName);
    }
}