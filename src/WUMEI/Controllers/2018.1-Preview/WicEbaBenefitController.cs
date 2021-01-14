using Microsoft.AspNetCore.Mvc;
using WUMEI.Models.V2018;

namespace WUMEI.Controllers.V2018
{
    /// <summary>
    /// The WIC EBA Benefit Maintenance functional area comprises functions for maintaining and querying
    /// benefit information associated with the EBAs in the WIC EBT System.
    /// </summary>
    [ApiVersion("2018.1-Preview", Deprecated = true)]
    [Route("WUMEISample/{version:apiVersion}/[controller]/[action]")]
    public class WicEbaBenefitController : Controller
    {
        /// <summary>
        /// The Add or Update Benefits function is a required function that uses a message based system
        /// interface to add (issue) or subtract (void) a benefit quantity from an EBA.
        /// </summary>
        /// <remarks>
        /// Issuing benefits results in an addition (credit) to the WIC cardholder’s benefits; voiding benefits
        /// results in a subtraction (debit).
        /// Current and future benefits may be issued, voided or placed on hold by using the date, begin benefit
        /// and date, end benefit data elements in this function.
        /// </remarks>
        /// <param name="input">
        /// Details of the benefits to be updated
        /// </param>
        /// <response code="200">
        /// Returns the updated message header
        /// </response>
        /// <returns>
        /// Returns a JSON response of type MessageHeader.
        /// </returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult AddUpdateBenefits([FromBody] AddUpdateBenefits input)
        {
            return Ok(input.MessageHeader);
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
        /// <param name="input">
        /// Details of the benefits to be returned.
        /// </param>
        /// <response code="200">
        /// Returns the updated message header and benefit details.
        /// </response>
        /// <returns>
        /// Returns a JSON response of type GetBenefitBalanceResult
        /// </returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetBenefitBalanceResult), 200)]
        public IActionResult GetBenefitBalance([FromBody] GetBenefitBalance input)
        {
            return Ok(new GetBenefitBalanceResult
            {
                MessageHeader = input.MessageHeader
            });
        }

        /// <summary>
        /// The GetBenefitMaintenanceHistory function is a required function that uses a message based system interface
        /// to retrieve benefit maintenance history information for a particular EBA.
        /// </summary>
        /// <param name="input">
        /// Details of the input to be returned.
        /// </param>
        /// <response code="200">
        /// Returns the updated message header and benefit details.
        /// </response>
        /// <returns>
        /// Returns a JSON response of type GetBenefitMaintenanceHistoryResult.
        /// </returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetBenefitMaintenanceHistoryResult), 200)]
        public IActionResult GetBenefitMaintenanceHistory(
                [FromBody] GetBenefitMaintenanceHistory input)
        {
            return Ok(new GetBenefitMaintenanceHistoryResult
            {
                MessageHeader = input.MessageHeader
            });
        }

        /// <summary>
        /// The Get Benefit Redemption History function is a required function that uses a message based system
        /// interface to retrieve benefit redemption data for a particular EBA.
        /// </summary>
        /// <remarks>
        /// This function allows the WIC MIS to retrieve from the WIC EBT system the benefit redemption history for
        /// a given period and a specific transaction type for the EBA and display it via the WIC MIS.
        /// Only transactions where redemption was attempted or completed (including those adjusted) are reported.
        /// </remarks>
        /// <param name="history">
        /// Details of the history to be returned.
        /// </param>
        /// <response code="200">
        /// Returns the updated message header and history details.
        /// </response>
        /// <returns>
        /// Returns a JSON response of type GetBenefitRedemptionHistoryResult.
        /// </returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetBenefitRedemptionHistoryResult), 200)]
        public IActionResult GetBenefitRedemptionHistory([FromBody]GetBenefitRedemptionHistory history)
        {
            return Ok(new GetBenefitRedemptionHistoryResult
            {
                MessageHeader = history.MessageHeader
            });
        }
    }
}
