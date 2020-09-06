using Insurance.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Insurance.Data
{
    /// <summary>
    /// Defines the <see cref="InsuranceContext" />.
    /// </summary>
    public class InsuranceContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsuranceContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{InsuranceContext}"/>.</param>
        public InsuranceContext(DbContextOptions<InsuranceContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Policies.
        /// </summary>
        public DbSet<Policy> Policies { get; set; }

        /// <summary>
        /// Gets or sets the Customers.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// The OnModelCreating.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/>.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Name = "Bob"
                },
                new Customer
                {
                    CustomerId = 2,
                    Name = "Jhon"
                });

            modelBuilder.Entity<Policy>().HasData(
                new Policy
                {
                    PolicyId = 1,
                    CustomerId = 1,
                    Name = "Poliza Contra Incendio",
                    TypeOfCovering = "Incendio",
                    CoveragePercentage = 100,
                    StartOfValidity = DateTime.Now.AddDays(2),
                    Period = 12,
                    Price = 1000000,
                    TypeOfRisk = "Bajo"
                }, new Policy
                {
                    PolicyId = 2,
                    CustomerId = 2,
                    Name = "Poliza Contra Robo",
                    TypeOfCovering = "Robo",
                    CoveragePercentage = 100,
                    StartOfValidity = DateTime.Now.AddDays(5),
                    Period = 12,
                    Price = 1000000,
                    TypeOfRisk = "Medio-Alto"
                }
            ); ;
        }
    }
}
