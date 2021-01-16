using System.Threading.Tasks;
using AwesomeNet.Core.GitHub.Abstractions;
using AwesomeNet.Core.GitHub.Common;

namespace AwesomeNet.Core.GitHub.Implementations
{
    /// <summary>
    /// Default implementation of IGitHubRepository abstraction
    /// Under hood use shared IHttpProvider to get connection to GitHub 
    /// </summary>
    public class GitHubRepository : IGitHubRepository
    {
        
        public string Name { get; }
        public string Owner { get; }
        
        
        public Task<GitHubRepositoryInfo> GetRepositoryInfoAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<GitHubFile> GetFileFromRootAsync(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public Task<GitHubFile> GetFileAsync(string path, string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}