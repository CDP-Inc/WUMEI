using Microsoft.AspNetCore.Mvc;
using WUMEI.Models.V2020;

namespace WUMEI.Controllers.V2020
{
    /// <summary>
    /// The WIC Vendor Maintenance functional area provides functions for maintaining WIC Vendor information,
    /// including banking information that is needed by the WIC EBT System.
    /// </summary>
    [ApiVersion("2020.1")]
    [Route("WUMEISample/{version:apiVersion}/[controller]/[action]")]
    public class WicVendorController : Controller
    {
        /// <summary>
        /// The Add or Update WIC Vendor function is a required function that uses a message or batch based
        /// system interface to establish or modify WIC Vendor information in the WIC EBT System.
        /// </summary>
        /// <param name="vendor">
        /// Details the vendor to be added or updated.
        /// </param>
        /// <response code="200">
        /// Returns the updated message header and status code.
        /// </response>
        /// <returns>
        /// Returns an <see cref="IActionResult"/> instance carrying the result data for the API caller.
        /// </returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AddUpdateWicVendorResult), 200)]
        public IActionResult AddUpdateWicVendor(
            [FromBody]AddUpdateWicVendor vendor)
        {
            return Ok(new AddUpdateWicVendorResult
            {
                MessageHeader = vendor.MessageHeader,
            });
        }

        /// <summary>
        /// The Add or Update WIC Vendor Hierarchy Information function is an optional function that uses a
        /// message or batch system interface to create and update the WIC EBT system’s WIC Vendor corporate
        /// levels of information.
        /// </summary>
        /// <param name="hierarchy"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult AddUpdateWicVendorHierarchyInformation(
            [FromBody] AddUpdateWicVendorHierarchyInformation hierarchy
            )
        {
            return Ok(hierarchy.MessageHeader);
        }

        /// <summary>
        /// The Update WIC Vendor Banking Information function is an optional function that uses a message or
        /// batch based system interface to add, change or delete banking information for a WIC Vendor in the WIC
        /// EBT system.
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult UpdateWicVendorBankingInformation(
            [FromBody] UpdateWicVendorBankingInformation vendor
        )
        {
            return Ok(vendor.MessageHeader);
        }
    }
}
