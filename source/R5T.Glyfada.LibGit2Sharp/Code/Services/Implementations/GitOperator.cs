using System;using R5T.T0064;


namespace R5T.Glyfada.LibGit2Sharp
{
    [ServiceImplementationMarker]
    public class GitOperator : IGitOperator,IServiceImplementation
    {
        public void Add(string path)
        {
            throw new NotImplementedException();
        }

        public void Clone(string repositoryURL, string localDirectoryPath)
        {
            throw new NotImplementedException();
        }

        public void Commit(string path, string message)
        {
            throw new NotImplementedException();
        }

        public void Fetch(string path)
        {
            throw new NotImplementedException();
        }

        public string GetRemoteRepositoryUrl(string path, string remoteRepositoryAlias = "origin")
        {
            throw new NotImplementedException();
        }

        public void Init(string directoryPath, bool quiet = false)
        {
            throw new NotImplementedException();
        }

        public bool IsUnderSourceControl(string path)
        {
            throw new NotImplementedException();
        }

        public void Pull(string path)
        {
            throw new NotImplementedException();
        }

        public void Push(string path)
        {
            throw new NotImplementedException();
        }
    }
}
