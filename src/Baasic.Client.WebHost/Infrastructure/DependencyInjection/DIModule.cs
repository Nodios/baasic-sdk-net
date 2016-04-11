using Baasic.Client.Infrastructure.DependencyInjection;
using Baasic.Client.Infrastructure.Security;

using System;

namespace Baasic.Client.WebHost.Infrastructure.DependencyInjection
{
    /// <summary>
    /// Dependency Injection Module containing Baasic Client bindings.
    /// </summary>
    public partial class DIModule : IDIModule
    {
        #region Methods

        /// <summary>
        /// Load dependency injection bindings.
        /// </summary>
        /// <param name="dependencyResolver"></param>
        public virtual void Load(IDependencyResolver dependencyResolver)
        {
            #region Security

            dependencyResolver.Register<ITokenHandler, WebSessionTokenHandler>();

            #endregion Security
        }

        #endregion Methods
    }
}