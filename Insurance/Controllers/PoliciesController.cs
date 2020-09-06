using Insurance.Business.Services;
using Insurance.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Insurance.Controllers
{
    /// <summary>
    /// Defines the <see cref="PoliciesController" />.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PoliciesController : ControllerBase
    {
        /// <summary>
        /// Defines the _policyService.
        /// </summary>
        private readonly IPolicyService _policyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesController"/> class.
        /// </summary>
        /// <param name="policyService">The policyService<see cref="PolicyService"/>.</param>
        public PoliciesController(IPolicyService policyService)
        {
            _policyService = policyService;
        }

        /// <summary>
        /// The GetPolicies.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Policy}"/>.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Policy>> GetPolicies()
        {
            return Ok(_policyService.GetAll());
        }

        // GET: api/Policies/customer/1
        /// <summary>
        /// The GetPoliciesByCustomer.
        /// </summary>
        /// <param name="customerId">The customerId<see cref="long"/>.</param>
        /// <returns>The <see cref="ActionResult{IEnumerable{Policy}}"/>.</returns>
        [HttpGet("customer/{customerId}")]
        public ActionResult<IEnumerable<Policy>> GetPoliciesByCustomer(long customerId)
        {
            return Ok(_policyService.GetByCustomerId(customerId));
        }

        // GET: api/Policies/5
        /// <summary>
        /// The GetPolicy.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="ActionResult{Policy}"/>.</returns>
        [HttpGet("{id}")]
        public ActionResult<Policy> GetPolicy(long id)
        {
            var policy = _policyService.GetById(id);

            if (policy == null)
            {
                return NotFound();
            }

            return Ok(policy);
        }

        // PUT: api/Policies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        /// <summary>
        /// The PutPolicy.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <param name="policy">The policy<see cref="Policy"/>.</param>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        [HttpPut("{id}")]
        public IActionResult PutPolicy(long id, Policy policy)
        {
            if (id != policy.PolicyId)
            {
                return BadRequest();
            }

            _policyService.Update(policy);

            return NoContent();
        }

        // POST: api/Policies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        /// <summary>
        /// The PostPolicy.
        /// </summary>
        /// <param name="policy">The policy<see cref="Policy"/>.</param>
        /// <returns>The <see cref="ActionResult{Policy}"/>.</returns>
        [HttpPost]
        public ActionResult<Policy> PostPolicy(Policy policy)
        {
            _policyService.Insert(policy);

            return CreatedAtAction("GetPolicy", new { id = policy.PolicyId }, policy);
        }

        // DELETE: api/Policies/5
        /// <summary>
        /// The DeletePolicy.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="ActionResult{Policy}"/>.</returns>
        [HttpDelete("{id}")]
        public ActionResult<Policy> DeletePolicy(long id)
        {
            var policy = _policyService.GetById(id);
            if (policy == null)
            {
                return NotFound();
            }

            _policyService.Delete(id);

            return policy;
        }

        /// <summary>
        /// The PolicyExists.
        /// </summary>
        /// <param name="id">The id<see cref="long"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool PolicyExists(long id)
        {
            return (_policyService.GetById(id) != null);
        }
    }
}
