using System;

namespace AwesomeNet.Core.GitHub.Common
{
    /// <summary>
    /// Represent GitHub file
    /// </summary>
    [Serializable]
    public class GitHubFile
    {
        /// <summary>
        /// Name of file. Must be with extension
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// File path according GitHub repo structure
        /// </summary>
        public string Path { get; }
        
        /// <summary>
        /// Content of file which provided as a string
        /// </summary>
        public string Content { get; }
        
        /// <summary>
        /// File Encoding format
        /// </summary>
        public string Encoding { get; }

        public GitHubFile(string name, string path, string content, string encoding)
        {
            Name = name;
            Path = path;
            Content = content;
            Encoding = encoding;
        }
    }
}