using Microsoft.AspNetCore.Mvc;
using WUMEI.Models.V2020;

namespace WUMEI.Controllers.V2020
{
    /// <summary>
    /// The WIC EBA Account Maintenance functional area comprises functions for maintaining an
    /// Electronic Benefit Account (EBA) in the WIC EBT System.
    /// </summary>
    [ApiVersion("2020.1")]
    [Route("WUMEISample/{version:apiVersion}/[controller]/[action]")]
    public class WicEbaAccountController : Controller
    {
        /// <summary>
        /// The Add EBA function is a required function that uses a message based system interface to establish an
        /// EBA in the WIC EBT System and link the EBA to a WIC account from the WIC MIS.
        /// </summary>
        /// <remarks>
        /// To establish an EBA account, only the WIC MIS account ID and Type code are required.
        /// The WIC EBT System expects that the WIC MIS shall perform any necessary checks for dual participation.
        /// </remarks>
        /// <param name="eba">Details of the new EBA to be added.</param>
        /// <response code="200">Returns the updated message header.</response>
        /// <returns>
        /// Returns an <see cref="IActionResult"/> instance carrying the result data for the API caller.
        /// </returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult AddEba([FromBody]AddEba eba)
        {
            return Ok(eba.MessageHeader);
        }

        /// <summary>
        /// The Update EBA function is a required function that uses a message based system interface to change
        /// the head of household date of birth, name, or address that is held in the WIC EBT database and/or
        /// to update an EBA with a new WIC MIS account ID.
        /// It is also used to change the status of an EBA by deactivating or reactivating or placing on hold
        /// an EBA in the WIC EBT system as indicated by the Action code.
        /// The WIC MIS account Type code for an EBA should not be changed using this function; instead the
        /// account should be deactivated and a new one with the correct type established.
        /// </summary>
        /// <remarks>
        /// It is recommended that WIC MIS support unique WIC MIS account IDs statewide.
        /// </remarks>
        /// <param name="eba">Details of the EBA to be updated.</param>
        /// <response code="200">Returns the updated message header and status code.</response>
        /// <returns>
        /// Returns an <see cref="IActionResult"/> instance carrying the result data for the API caller.
        /// </returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UpdateEbaResult), 200)]
        public IActionResult UpdateEba([FromBody]UpdateEba eba)
        {
            return Ok(new UpdateEbaResult
            {
                MessageHeader = eba.MessageHeader,
                StatusCode = "A001"
            });
        }

        /// <summary>
        /// The Get EBA Details function is a required function that uses a message based system interface to
        /// return detailed information on the EBA.
        /// </summary>
        /// <remarks>
        /// This function allows a WIC MIS user the ability to have EBA information displayed via a WIC MIS screen.
        /// The WIC EBT system shall identify the EBA and return the household data information available.
        /// </remarks>
        /// <param name="input">Details of the EBA to be returned.</param>
        /// <response code="200">Returns the updated message header and EBA details.</response>
        /// <returns>
        /// Returns an <see cref="IActionResult"/> instance carrying the result data for the API caller.
        /// </returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetEbaDetailsResult), 200)]
        public IActionResult GetEbaDetails([FromBody]GetEbaDetails input)
        {
            return Ok(new GetEbaDetailsResult
            {
                MessageHeader = input.MessageHeader
            });
        }
    }
}
