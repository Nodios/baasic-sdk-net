﻿using System;

namespace Baasic.Client.Infrastructure.Security
{
    /// <summary>
    /// Authentication token details.
    /// </summary>
    public class AuthenticationToken : IAuthenticationToken
    {
        #region Properties

        /// <summary>
        /// Token expiration date.
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets if token is valid.
        /// </summary>
        public bool IsValid
        {
            get
            {
                return this.ExpirationDate >= DateTime.UtcNow;
            }
        }

        /// <summary>
        /// Gets token scheme.
        /// </summary>
        public string Scheme { get; set; }

        /// <summary>
        /// Gets token.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets the URL token.
        /// </summary>
        /// <value>The URL token.</value>
        public string UrlToken { get; set; }

        #endregion Properties
    }
}