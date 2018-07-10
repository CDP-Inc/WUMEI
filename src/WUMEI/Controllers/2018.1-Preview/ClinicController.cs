using Microsoft.AspNetCore.Mvc;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// The Clinic Maintenance functional area comprises functions for creating and updating clinic information needed by the WIC EBT System.
    /// </summary>
    [ApiVersion("2018.1-Preview")]
    [Route("WUMEISample/{version:apiVersion}/[controller]/[action]")]
    public class ClinicController : Controller
    {
        /// <summary>
        /// The Add Clinic function is an optional function that uses a message based system interface to add a clinic information record in the WIC EBT System.
        /// </summary>
        /// <param name="clinic">Details of the new clinic to be added.</param>
        /// <response code="200">Returns the updated message header.</response>   
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult AddClinic(
            [FromBody]AddClinic clinic
        )
        {
            return Ok(clinic.MessageHeader);
        }

        /// <summary>
        /// The Update Clinic function is an optional function that uses a message based system interface to update, activate, deactivate or change the status of the clinic record in the WIC EBT System.
        /// </summary>
        /// <remarks>
        /// The WIC EBT System will not accept transactions from a clinic once it has been deactivated.
        /// </remarks>
        /// <param name="clinic">Details of the clinic to be updated.</param>
        /// <response code="200">Returns the updated message header.</response>   
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult UpdateClinic(
            [FromBody]UpdateClinic clinic
        )
        {
            return Ok(clinic.MessageHeader);
        }
    }
}