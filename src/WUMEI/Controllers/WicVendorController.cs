using Microsoft.AspNetCore.Mvc;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// The WIC Vendor Maintenance functional area provides functions for maintaining WIC Vendor information, 
    /// including banking information that is needed by the WIC EBT System.
    /// </summary>
    [Route("wumei/[controller]/[action]")]
    public class WicVendorController : Controller
    {
        /// <summary>
        /// The Add or Update WIC Vendor function is a required function that uses a message or batch based 
        /// system interface to establish or modify WIC Vendor information in the WIC EBT System.
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AddUpdateWicVendorResult), 200)]
        public IActionResult AddUpdateWicVendor(
            [FromBody]AddUpdateWicVendor vendor
        )
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
            [FromBody]AddUpdateWicVendorHierarchyInformation hierarchy
            )
        {
            return Ok(hierarchy.MessageHeader);
        }

        /// <summary>
        /// The Update WIC Vendor Status function is an optional function that uses a message or batch system
        /// interface to set the new status of the WIC Vendor.
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult UpdateWicVendorStatus(
            [FromBody]UpdateWicVendorStatus vendor
        )
        {
            return Ok(vendor.MessageHeader);
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
            [FromBody]UpdateWicVendorBankingInformation vendor
        )
        {
            return Ok(vendor.MessageHeader);
        }
    }
}