using System;

namespace AwesomeNet.Core.GitHub.Common
{
    /// <summary>
    /// Represent common info about GitHub repository
    /// </summary>
    [Serializable]
    public class GitHubRepositoryInfo
    {
        /// <summary>
        /// Unique Id of each GitHub repository
        /// </summary>
        public string Id { get; }
        
        /// <summary>
        /// Id of node where GitHub repo is located  (must be clarify)
        /// </summary>
        public string NodeId { get; }
        
        /// <summary>
        /// Name of GitHub repo
        /// </summary>
        public string Name { get; }
        
        public bool IsPrivate { get; }
        
        /// <summary>
        /// Full name of GitHub repo
        /// </summary>
        public string FullName { get; }
        
        public GitHubRepositoryInfo(string id, string full_name, string node_id, string name, bool @private)
        {
            Id = id;
            FullName = full_name;
            NodeId = node_id;
            Name = name;
            IsPrivate = @private;
        }
    }
}