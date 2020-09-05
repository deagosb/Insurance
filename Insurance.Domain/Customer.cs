﻿namespace Insurance.Domain
{
    /// <summary>
    /// Defines the <see cref="Customer" />.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the CustomerId.
        /// </summary>
        public long CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }
    }
}