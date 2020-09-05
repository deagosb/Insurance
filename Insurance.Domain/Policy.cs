using System;

namespace Insurance.Domain
{
    /// <summary>
    /// Defines the <see cref="Policy" />.
    /// </summary>
    public class Policy
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Int64 Id { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the TypeOfCovering.
        /// </summary>
        public string TypeOfCovering { get; set; }

        /// <summary>
        /// Gets or sets the CoveragePercentage.
        /// </summary>
        public int CoveragePercentage { get; set; }

        /// <summary>
        /// Gets or sets the StartOfValidity.
        /// </summary>
        public DateTime StartOfValidity { get; set; }

        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        public int Period { get; set; }

        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Gets or sets the TypeOfRisk.
        /// </summary>
        public string TypeOfRisk { get; set; }
    }
}
