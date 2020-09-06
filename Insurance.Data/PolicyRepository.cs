using Insurance.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Insurance.Data
{
    /// <summary>
    /// Defines the <see cref="PolicyRepository" />.
    /// </summary>
    public class PolicyRepository : IPolicyRepository
    {
        /// <summary>
        /// Defines the _context.
        /// </summary>
        private readonly InsuranceContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyRepository"/> class.
        /// </summary>
        /// <param name="context">The context<see cref="InsuranceContext"/>.</param>
        public PolicyRepository(InsuranceContext context)
        {
            _context = context;
        }

        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Policy}"/>.</returns>
        public IEnumerable<Policy> GetAll()
        {
            return _context.Policies.ToList();
        }

        /// <summary>
        /// The GetByCustomerId.
        /// </summary>
        /// <param name="customerId">The customerId<see cref="long"/>.</param>
        /// <returns>The <see cref="IEnumerable{Policy}"/>.</returns>
        public IEnumerable<Policy> GetByCustomerId(long customerId)
        {
            return _context.Policies.Where(x => x.CustomerId == customerId).ToList();
        }

        /// <summary>
        /// The GetById.
        /// </summary>
        /// <param name="policyId">The policyId<see cref="long"/>.</param>
        /// <returns>The <see cref="Policy"/>.</returns>
        public Policy GetById(long policyId)
        {
            return _context.Policies.Find(policyId);
        }

        /// <summary>
        /// The Insert.
        /// </summary>
        /// <param name="policy">The policy<see cref="Policy"/>.</param>
        public void Insert(Policy policy)
        {
            _context.Policies.Add(policy);
        }

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="policy">The policy<see cref="Policy"/>.</param>
        public void Update(Policy policy)
        {
            _context.Entry(policy).State = EntityState.Modified;
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="policyId">The policyId<see cref="long"/>.</param>
        public void Delete(long policyId)
        {
            Policy policy = _context.Policies.Find(policyId);
            _context.Policies.Remove(policy);
        }

        /// <summary>
        /// The Save.
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Defines the disposed.
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// The Dispose.
        /// </summary>
        /// <param name="disposing">The disposing<see cref="bool"/>.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// The Dispose.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
