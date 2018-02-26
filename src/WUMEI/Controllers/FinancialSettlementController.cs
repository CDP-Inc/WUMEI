using Microsoft.AspNetCore.Mvc;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// The Financial Settlement functional area comprises functions for effecting financial transactions from
    /// the WIC EBT system to the WIC Vendor
    /// </summary>
    [Route("wumei/[controller]/[action]")]
    public class FinancialSettlementController : Controller
    {
        /// <summary>
        /// The Request ACH Payment function is an optional function that uses a message or batch based system 
        /// interface to allow the WIC State Agency or EBT Card Issuer Processor to make a payment or adjustment
        /// to a WIC Vendor, a WIC Vendor corporate entity or their agent that is outside the normal course of
        /// benefit redemption and settlement.
        /// </summary>
        /// <param name="ach"></param>
        /// <response code="200">Returns the updated message header.</response>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult RequestAchPayment(
            [FromBody]RequestAchPayment ach
        )
        {
            return Ok(ach.MessageHeader);
        }
    }
}
