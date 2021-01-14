using Microsoft.AspNetCore.Mvc;
using WUMEI.Models.V2020;

namespace WUMEI.Controllers.V2020
{
    /// <summary>
    /// The WIC Food Maintenance functional area includes functions for creating and updating the list of food
    /// categories and sub-categories used by the WIC State Agency, creating and maintaining the list of UPC/PLU data
    /// for food items and creating and maintaining the NTE price for a food item.
    /// </summary>
    [ApiVersion("2020.1")]
    [Route("WUMEISample/{version:apiVersion}/[controller]/[action]")]
    public class FoodController : Controller
    {
        /// <summary>
        /// The Get Category Information function is an optional function that uses a message based system interface
        /// to provide the food category information from the system maintaining the interface to the NUPC database.
        /// </summary>
        /// <param name="input">Only an incoming message header</param>
        /// <returns>An ActionResult containing the category information</returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetCategoryInformationResult), 200)]
        public IActionResult GetCategoryInformation(
            [FromBody] GetCategoryInformation input)
        {
            return Ok(new GetCategoryInformationResult
            {
                MessageHeader = input.MessageHeader
            });
        }

        /// <summary>
        /// The Get Sub-Category Information function is an optional function that uses a message based system
        /// interface to provide the food Sub-Category information from the system maintaining the interface to the
        /// NUPC database. A batch of messages may be returned providing all of the sub-categories on file.
        /// </summary>
        /// <param name="input">Only an incoming message header</param>
        /// <returns>An ActionResult containing the subcategory information</returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetSubcategoryInformationResult), 200)]
        public IActionResult GetSubcategoryInformation(
            [FromBody] GetSubcategoryInformation input)
        {
            return Ok(new GetSubcategoryInformationResult
            {
                MessageHeader = input.MessageHeader
            });
        }

        /// <summary>
        /// The Get UPC Information function is an optional function that uses a message based system interface
        /// to provide the UPC information from the system maintaining the interface to the NUPC database.
        /// </summary>
        /// <param name="input">Mesage header and details of UPC/PLU to be returned</param>
        /// <returns>An ActionResult containing the result data for the UPC information</returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetUpcInformationResult), 200)]
        public IActionResult GetUpcInformation(
            [FromBody] GetUpcInformation input)
        {
            return Ok(new GetUpcInformationResult
            {
                MessageHeader = input.MessageHeader
            });
        }
    }
}
