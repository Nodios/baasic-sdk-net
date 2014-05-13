﻿using System;

namespace Baasic.Client.Model
{
    /// <summary>
    /// Value set item used to transfer data from and to Baasic.
    /// </summary>
    public class ValueSetItem : ModelBase
    {
        /// <summary>
        /// Gets or sets the set id.
        /// </summary>
        public virtual Guid SetId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the set name.
        /// </summary>
        public virtual string SetName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the KeyValueItem value.
        /// </summary>
        public virtual string Value
        {
            get;
            set;
        }
    }
}