using Microsoft.AspNetCore.Mvc;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// The WIC EBA Benefit Maintenance functional area comprises functions for maintaining and querying
    /// benefit information associated with the EBAs in the WIC EBT System.
    /// </summary>
    [ApiVersion("2018.1-Preview")]
    [Route("WUMEISample/{version:apiVersion}/[controller]/[action]")]
    public class WicEbaBenefitController : Controller
    {
        /// <summary>
        /// The Add or Update Benefits function is a required function that uses a message based system 
        /// interface to add (issue) or subtract (void) a Benefit quantity from an EBA.
        /// </summary>
        /// <remarks>
        /// Issuing benefits results in an addition (credit) to the WIC Cardholder’s benefits; voiding benefits 
        /// results in a subtraction (debit). 
        /// Current and future benefits may be issued, voided or placed on hold by using the Date, begin benefit 
        /// and Date, end benefit data elements in this function.
        /// </remarks>
        /// <param name="benefits">Details of the benefits to be updated.</param>
        /// <response code="200">Returns the updated message header and status code.</response>    
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AddUpdateBenefitsResult), 200)]
        public IActionResult AddUpdateBenefits(
            [FromBody]AddUpdateBenefits benefits
        )
        {
            return Ok(new AddUpdateBenefitsResult
            {
                MessageHeader = benefits.MessageHeader
            });
        }

        /// <summary>
        /// The Get Benefit Balance function is a required function that uses a message based system interface
        /// to retrieve benefit information for a particular EBA.
        /// </summary>
        /// <remarks>
        /// This function allows the WIC MIS to retrieve from the WIC EBT system the remaining balance for
        /// the EBA and display it via the WIC MIS.
        /// Note that the benefit balance is reported at the household level only.
        /// </remarks>
        /// <param name="input">Details of the benefits to be returned.</param>
        /// <response code="200">Returns the updated message header and benefit details.</response>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetBenefitBalanceResult), 200)]
        public IActionResult GetBenefitBalance(
            [FromBody] GetBenefitBalance input
        )
        {
            return Ok(new GetBenefitBalanceResult
            {
                MessageHeader = input.MessageHeader
            });
        }

        /// <summary>
        /// The Get Benefit Maintenance History function is a required function that uses a message 
        /// based system interface to retrieve benefit maintenance transaction data for a particular EBA.
        /// </summary>
        /// <remarks>
        /// This function allows the WIC MIS to retrieve from the WIC EBT system the benefit maintenance
        /// transaction history for a given period for the EBA and display it via the WIC MIS. 
        /// This function may also be used by the WIC EBT system to retrieve information from the WIC MIS. 
        /// All benefit additions, voids and purges may be retrieved using this function. 
        /// The retention period for benefit data shall be defined by bilateral agreement.
        /// </remarks>
        /// <param name="history">Details of the history to be returned.</param>
        /// <response code="200">Returns the updated message header and history details.</response>    
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetBenefitMaintenanceHistoryResult), 200)]
        public IActionResult GetBenefitMaintenanceHistory(
            [FromBody]GetBenefitMaintenanceHistory history
        )
        {
            return Ok(new GetBenefitMaintenanceHistoryResult
            {
                MessageHeader = history.MessageHeader
            });
        }

        /// <summary>
        /// The Get Benefit Redemption History function is a required function that uses a message based system interface to retrieve benefit redemption data for a particular EBA.
        /// </summary>
        /// <remarks>
        /// This function allows the WIC MIS to retrieve from the WIC EBT system the benefit redemption history for a given period and a specific transaction type for the EBA and display it via the WIC MIS. 
        /// Only transactions where redemption was attempted or completed (including those adjusted) are reported.
        /// </remarks>
        /// <param name="history">Details of the history to be returned.</param>
        /// <response code="200">Returns the updated message header and history details.</response>    
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetBenefitRedemptionHistoryResult), 200)]
        public IActionResult GetBenefitRedemptionHistory(
            [FromBody]GetBenefitRedemptionHistory history
        )
        {
            return Ok(new GetBenefitRedemptionHistoryResult
            {
                MessageHeader = history.MessageHeader
            });
        }
    }
}
