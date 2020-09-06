using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Insurance.Data
{
    /// <summary>
    /// Defines the <see cref="DesignTimeDbContextFactory" />.
    /// </summary>
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<InsuranceContext>
    {
        /// <summary>
        /// The CreateDbContext.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        /// <returns>The <see cref="InsuranceContext"/>.</returns>
        public InsuranceContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<InsuranceContext>();
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Insurance;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new InsuranceContext(optionsBuilder.Options);
        }
    }
}
