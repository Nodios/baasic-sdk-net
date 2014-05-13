﻿using Baasic.Client.Configuration;
using System;

namespace Baasic.Client.Internals
{
    /// <summary>
    /// Factory used to instantiate objects.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Creates the baasic client.
        /// </summary>
        /// <returns>Baasic client.</returns>
        IBaasicClient CreateBaasicClient();

        /// <summary>
        /// Creates the client configuration.
        /// </summary>
        /// <returns>Client configuration.</returns>
        IClientConfiguration CreateClientConfiguration();

        /// <summary>
        /// Create client configuration.
        /// </summary>
        /// <param name="applicationIdentifier">Application identifier.</param>
        /// <returns>Client configuration.</returns>
        IClientConfiguration CreateClientConfiguration(string applicationIdentifier);

        /// <summary>
        /// Create client configuration.
        /// </summary>
        /// <param name="applicationIdentifier">Application identifier.</param>
        /// <returns>Client configuration.</returns>
        IClientConfiguration CreateClientConfiguration(string baseAddress, string applicationIdentifier);
    }
}