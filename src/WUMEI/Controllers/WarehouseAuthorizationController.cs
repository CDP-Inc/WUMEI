using Microsoft.AspNetCore.Mvc;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// The Warehouse Authorization functional area comprised functions geared toward generating and removing
    /// authorizations for the purchase of items from warehouse vendors that ship authorized items.
    /// </summary>
    /// <remarks>
    /// Since the cardholder is not present when a warehouse fulfills an order, an alternative to PIN entry
    /// is required to maintain the integrity of the transaction.
    /// </remarks>
    [Route("wumei/[controller]/[action]")]
    public class WarehouseAuthorizationController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="auth"></param>
        /// <returns></returns>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(RequestWarehouseAuthorizationResult), 200)]
        public IActionResult RequestWarehouseAuthorization(
            [FromBody]RequestWarehouseAuthorization auth
        )
        {
            return Ok(new RequestWarehouseAuthorizationResult
            {
                MessageHeader = auth.MessageHeader,
            });
        }

        /// <summary>
        /// Allows the MIS to request that the WIC EBT System void a given authorization
        /// that has previously been requested.
        /// </summary>
        /// <param name="auth"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(VoidWarehouseAuthorizationResult), 200)]
        public IActionResult VoidWarehouseAuthorization(
            [FromBody]VoidWarehouseAuthorization auth
        )
        {
            return Ok(new VoidWarehouseAuthorizationResult
            {
                MessageHeader = auth.MessageHeader,
            });
        }

        /// <summary>
        /// Optional function that gets a list of matching warehouse authorizations.
        /// </summary>
        /// <remarks>
        /// Requires at least one primary filter to be provided to return authorizations
        /// for an account, vendor, or product.
        /// </remarks>
        /// <param name="auth"></param>
        /// <returns></returns>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetWarehouseAuthorizationsResult), 200)]
        public IActionResult GetWarehouseAuthorizations(
            [FromBody]GetWarehouseAuthorizations auth
        )
        {
            return Ok(new GetWarehouseAuthorizationsResult
            {
                MessageHeader = auth.MessageHeader,
            });
        }

        /// <summary>
        /// Gets an authorization code from a previous approved warehouse authorization.
        /// </summary>
        /// <param name="auth"></param>
        /// <returns></returns>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetWarehouseAuthorizationCodeResult), 200)]
        public IActionResult GetWarehouseAuthorizationCode(
            [FromBody]GetWarehouseAuthorizationCode auth
        )
        {
            return Ok(new GetWarehouseAuthorizationCodeResult
            {
                MessageHeader = auth.MessageHeader,
            });
        }
    }
}
