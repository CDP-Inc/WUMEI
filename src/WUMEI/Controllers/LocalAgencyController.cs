using Microsoft.AspNetCore.Mvc;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// The Local Agency Maintenance functional area comprises functions for creating and updating local agency information needed by the WIC EBT System for reporting purposes.
    /// </summary>
    [Route("wumei/[controller]/[action]")]
    public class LocalAgencyController : Controller
    {
        /// <summary>
        /// The Add Local Agency function is an optional function that uses a message based system interface to create a local agency information record in the WIC EBT System.
        /// </summary>
        /// <param name="localAgency">Details of the new local agency to be added.</param>
        /// <response code="200">Returns the updated message header.</response>   
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult AddLocalAgency(
            [FromBody]AddLocalAgency localAgency
        )
        {
            return Ok(localAgency.MessageHeader);
        }

        /// <summary>
        /// The Update Local Agency function is an optional function that uses a message based system interface to update the local agency information record in the WIC EBT System, including activating and deactivating the local agency.
        /// </summary>
        /// <param name="localAgency">Details of the local agency to be updated.</param>
        /// <response code="200">Returns the updated message header.</response>   
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult UpdateLocalAgency(
            [FromBody]UpdateLocalAgency localAgency
        )
        {
            return Ok(localAgency.MessageHeader);
        }
    }
}