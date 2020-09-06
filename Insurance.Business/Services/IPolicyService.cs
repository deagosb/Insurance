using Insurance.Domain;
using System.Collections.Generic;

namespace Insurance.Business.Services
{
    /// <summary>
    /// Defines the <see cref="IPolicyService" />.
    /// </summary>
    public interface IPolicyService
    {
        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Policy}"/>.</returns>
        IEnumerable<Policy> GetAll();

        /// <summary>
        /// The GetByCustomerId.
        /// </summary>
        /// <param name="customerId">The customerId<see cref="long"/>.</param>
        /// <returns>The <see cref="IEnumerable{Policy}"/>.</returns>
        IEnumerable<Policy> GetByCustomerId(long customerId);

        /// <summary>
        /// The GetById.
        /// </summary>
        /// <param name="policyId">The policyId<see cref="long"/>.</param>
        /// <returns>The <see cref="Policy"/>.</returns>
        Policy GetById(long policyId);

        /// <summary>
        /// The Insert.
        /// </summary>
        /// <param name="policy">The policy<see cref="Policy"/>.</param>
        void Insert(Policy policy);

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="policy">The policy<see cref="Policy"/>.</param>
        void Update(Policy policy);

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="policyId">The policyId<see cref="long"/>.</param>
        void Delete(long policyId);

        /// <summary>
        /// The ComplyBusinessRule.
        /// </summary>
        /// <param name="typeOfRisk">The typeOfRisk<see cref="string"/>.</param>
        /// <param name="coveragePercentage">The coveragePercentage<see cref="int"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool ComplyBusinessRule(string typeOfRisk, int coveragePercentage);
    }
}
