using Insurance.Business.Services;
using Insurance.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Insurance.Business.XUnitTest
{
    /// <summary>
    /// Defines the <see cref="PolicyServiceTest" />.
    /// </summary>
    public class PolicyServiceTest
    {
        /// <summary>
        /// Defines the _insuranceContext.
        /// </summary>
        private readonly InsuranceContext _insuranceContext;

        /// <summary>
        /// Defines the _policyRepository.
        /// </summary>
        private readonly PolicyRepository _policyRepository;

        /// <summary>
        /// Defines the _policyService.
        /// </summary>
        private readonly PolicyService _policyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyServiceTest"/> class.
        /// </summary>
        public PolicyServiceTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<InsuranceContext>();
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Insurance;Trusted_Connection=True;MultipleActiveResultSets=true");

            _insuranceContext = new InsuranceContext(optionsBuilder.Options);
            _policyRepository = new PolicyRepository(_insuranceContext);
            _policyService = new PolicyService(_policyRepository);
        }

        /// <summary>
        /// The Business_Rule_Fails.
        /// </summary>
        [Fact]
        public void Business_Rule_Fails()
        {
            Assert.False(_policyService.ComplyBusinessRule("Alto", 51));
        }

        /// <summary>
        /// The Business_Rule_Sucessfully.
        /// </summary>
        [Fact]
        public void Business_Rule_Sucessfully()
        {
            Assert.True(_policyService.ComplyBusinessRule("Alto", 50));
        }
    }
}
