﻿using Baasic.Client.Configuration;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Baasic.Client
{
    /// <summary>
    /// Baasic client contract.
    /// </summary>
    public interface IBaasicClient : IDisposable
    {
        #region Properties

        /// <summary>
        /// Gets or sets client configuration.
        /// </summary>
        IClientConfiguration Configuration { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Create string content.
        /// </summary>
        /// <param name="data">Data.</param>
        /// <param name="mthv">Media type.</param>
        /// <returns>String content.</returns>
        StringContent CreateStringContent(string data, string mthv);

        /// <summary>
        /// Asynchronously deletes the object from the system.
        /// </summary>
        /// <param name="requestUri">Request URI.</param>
        /// <returns>True if object is deleted, false otherwise.</returns>
        Task<bool> DeleteAsync(string requestUri);

        /// <summary>
        /// Asynchronously deletes the object from the system.
        /// </summary>
        /// <param name="requestUri">Request URI.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True if object is deleted, false otherwise.</returns>
        Task<bool> DeleteAsync(string requestUri, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the API URL.
        /// </summary>
        /// <param name="relativeUrl">The relative URL.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        string GetApiUrl(string relativeUrl, params object[] parameters);

        /// <summary>
        /// Gets the API URL.
        /// </summary>
        /// <param name="ssl">if set to <c>true</c> [SSL].</param>
        /// <param name="relativeUrl">The relative URL.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        string GetApiUrl(bool ssl, string relativeUrl, params object[] parameters);

        /// <summary>
        /// Asynchronously gets the <typeparamref name="T" /> from the system.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="requestUri">Request URI.</param>
        /// <returns><typeparamref name="T" />.</returns>
        Task<T> GetAsync<T>(string requestUri);

        /// <summary>
        /// Asynchronously gets the <typeparamref name="T" /> from the system.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="requestUri">Request URI.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns><typeparamref name="T" />.</returns>
        Task<T> GetAsync<T>(string requestUri, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the secure API URL.
        /// </summary>
        /// <param name="relativeUrl">The relative URL.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        string GetSecureApiUrl(string relativeUrl, params object[] parameters);

        /// <summary>
        /// Asynchronously insert the <typeparamref name="T" /> into the system.
        /// </summary>
        /// <typeparam name="T">Resource type.</typeparam>
        /// <param name="requestUri">Request URI.</param>
        /// <param name="content">Resource instance.</param>
        /// <returns>Newly created <typeparamref name="T" />.</returns>
        Task<T> PostAsync<T>(string requestUri, T content);

        /// <summary>
        /// Asynchronously insert the <typeparamref name="T" /> into the system.
        /// </summary>
        /// <typeparam name="T">Resource type.</typeparam>
        /// <param name="requestUri">Request URI.</param>
        /// <param name="content">Resource instance.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Newly created <typeparamref name="T" />.</returns>
        Task<T> PostAsync<T>(string requestUri, T content, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously update the <typeparamref name="T" /> in the system.
        /// </summary>
        /// <typeparam name="T">Resource type.</typeparam>
        /// <param name="requestUri">Request URI.</param>
        /// <param name="content">Resource instance.</param>
        /// <returns>Updated <typeparamref name="T" />.</returns>
        Task<T> PutAsync<T>(string requestUri, T content);

        /// <summary>
        /// Asynchronously update the <typeparamref name="T" /> in the system.
        /// </summary>
        /// <typeparam name="T">Resource type.</typeparam>
        /// <param name="requestUri">Request URI.</param>
        /// <param name="content">Resource instance.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Updated <typeparamref name="T" />.</returns>
        Task<T> PutAsync<T>(string requestUri, T content, CancellationToken cancellationToken);

        #endregion Methods
    }
}