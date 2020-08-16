using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Glyfada.LibGit2Sharp
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GitOperator"/> implementation of <see cref="IGitOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddGitOperator(this IServiceCollection services)
        {
            services.AddSingleton<IGitOperator, GitOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="GitOperator"/> implementation of <see cref="IGitOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitOperator> AddGitOperatorAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IGitOperator>(() => services.AddGitOperator());
            return serviceAction;
        }
    }
}
