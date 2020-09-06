using Insurance.Data;
using Insurance.Domain;
using System.Collections.Generic;

namespace Insurance.Business.Services
{
    /// <summary>
    /// Defines the <see cref="PolicyService" />.
    /// </summary>
    public class PolicyService : IPolicyService
    {
        /// <summary>
        /// Defines the _policyRepository.
        /// </summary>
        private readonly IPolicyRepository _policyRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyService"/> class.
        /// </summary>
        /// <param name="policyRepository">The policyRepository<see cref="PolicyRepository"/>.</param>
        public PolicyService(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository;
        }

        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Policy}"/>.</returns>
        public IEnumerable<Policy> GetAll()
        {
            return _policyRepository.GetAll();
        }

        /// <summary>
        /// The GetByCustomerId.
        /// </summary>
        /// <param name="customerId">The customerId<see cref="long"/>.</param>
        /// <returns>The <see cref="IEnumerable{Policy}"/>.</returns>
        public IEnumerable<Policy> GetByCustomerId(long customerId)
        {
            return _policyRepository.GetByCustomerId(customerId);
        }

        /// <summary>
        /// The GetById.
        /// </summary>
        /// <param name="policyId">The policyId<see cref="long"/>.</param>
        /// <returns>The <see cref="Policy"/>.</returns>
        public Policy GetById(long policyId)
        {
            return _policyRepository.GetById(policyId);
        }

        /// <summary>
        /// The Insert.
        /// </summary>
        /// <param name="policy">The policy<see cref="Policy"/>.</param>
        public void Insert(Policy policy)
        {
            _policyRepository.Insert(policy);
        }

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="policy">The policy<see cref="Policy"/>.</param>
        public void Update(Policy policy)
        {
            _policyRepository.Update(policy);
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="policyId">The policyId<see cref="long"/>.</param>
        public void Delete(long policyId)
        {
            _policyRepository.Delete(policyId);
        }

        /// <summary>
        /// The ComplyBusinessRule.
        /// </summary>
        /// <param name="typeOfRisk">The typeOfRisk<see cref="string"/>.</param>
        /// <param name="coveragePercentage">The coveragePercentage<see cref="int"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool ComplyBusinessRule(string typeOfRisk, int coveragePercentage)
        {
            if (typeOfRisk == "alto")
            {
                if (coveragePercentage > 50)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
