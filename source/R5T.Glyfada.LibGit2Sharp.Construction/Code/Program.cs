using System;
using System.Linq;

using global::LibGit2Sharp;

using R5T.Magyar.IO;


namespace R5T.Glyfada.LibGit2Sharp.Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.CreateNewRepository();
            //Program.ClonePrivateRepository();
            Program.ExploreLibGit2Sharp();
        }

        /// <summary>
        /// Adapted from: https://edi.wang/post/2019/3/26/operate-git-with-net-core
        /// </summary>
        private static void ExploreLibGit2Sharp()
        {
            var writer = Console.Out;

            var repositoryDirectoryPath = @"C:\Temp\R5T.E0004.Private";
            using (var repository = new Repository(repositoryDirectoryPath))
            {
                writer.WriteLine($"Branch count: {repository.Branches.Count()}");

                foreach (var branch in repository.Branches)
                {
                    writer.WriteLine($"{branch.FriendlyName} is head? {branch.IsCurrentRepositoryHead}");

                    if(branch.IsCurrentRepositoryHead)
                    {
                        var localBranchAheadBy = branch.TrackingDetails.AheadBy.GetValueOrDefault();

                        writer.WriteLine($"Remote branch ahead by: {localBranchAheadBy}");
                    }
                }

                var statusOptions = new StatusOptions()
                {

                };

                var repositoryStatus = repository.RetrieveStatus();
                
                repository.analyze


                var mergeOptions = new MergeOptions
                {
                    FastForwardStrategy = FastForwardStrategy.
                }

                var mergeResult = repository.Merge(,);

                var commit = repository.Commits.First();
                
                var fetchResult = repository.

                var repositoryStatus = repository.RetrieveStatus();


                global::LibGit2Sharp.Handlers.

                Commands.Fetch()
            }
        }

        private static void ClonePrivateRepository()
        {
            Credentials CredentialsProvider(string url, string t, SupportedCredentialTypes supportedCredentialTypes)
            {
                var credentials = new UsernamePasswordCredentials
                {
                    Username = "davidcoats",
                    Password = "PersonalCode2019@)!(",
                };

                return credentials;
            }

            var cloneOptions = new CloneOptions
            {
                CredentialsProvider = CredentialsProvider,
            };

            var repositoryDirectoryPath = @"C:\Temp\R5T.E0004.Private";
            Repository.Clone("https://github.com/SafetyCone/R5T.E0004.Private.git", repositoryDirectoryPath, cloneOptions);
        }

        private static void CreateNewRepository()
        {
            var writer = Console.Out;

            // Initialze a new repository.
            var testingRepositoryPath = @"C:\Temp\GitRepository";
            DirectoryHelper.DeleteDirectoryOkIfNotExists(testingRepositoryPath);

            var actualTestingRepositoryPath = Repository.Init(testingRepositoryPath); // The .git directory.
            using (var testingRepository = new Repository(testingRepositoryPath))
            {
                var repoStatus = testingRepository.RetrieveStatus();

                writer.WriteLine($"{nameof(repoStatus.IsDirty)}: {repoStatus.IsDirty}");

                writer.WriteLine($"{nameof(testingRepository.Info.WorkingDirectory)}: {testingRepository.Info.WorkingDirectory}");
            }
        }
    }
}
