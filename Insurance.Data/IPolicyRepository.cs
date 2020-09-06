using Insurance.Domain;
using System.Collections.Generic;

namespace Insurance.Data
{
    /// <summary>
    /// Defines the <see cref="IPolicyRepository" />.
    /// </summary>
    public interface IPolicyRepository
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
        /// The Save.
        /// </summary>
        void Save();
    }
}
