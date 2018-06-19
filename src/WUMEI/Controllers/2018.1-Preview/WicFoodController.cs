using Microsoft.AspNetCore.Mvc;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// The WIC Food Maintenance functional area includes functions for creating and updating the list of 
    /// food categories and sub-categories used by the WIC State Agency, creating and maintaining the list of 
    /// UPC/PLU data for food items and creating and maintaining the NTE price for a food item.
    /// </summary>
    [ApiVersion("2018.1-Preview")]
    [Route("WUMEI/{version:apiVersion}/[controller]/[action]")]
    public class WicFoodController : Controller
    {
        /// <summary>
        /// The Get Category Information function is an optional function that uses a message based system
        /// interface to provide the food category information from the system maintaining the interface to the
        /// NUPC database.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetCategoryInformationResult), 200)]
        public IActionResult GetCategoryInformation(
            [FromBody]GetCategoryInformation category)
        {
            return Ok(new GetCategoryInformationResult
            {
                MessageHeader = category.MessageHeader
            });
        }

        /// <summary>
        /// The Get Sub-Category Information function is an optional function that uses a message based system
        /// interface to provide the food Sub-Category information from the system maintaining the interface to 
        /// the NUPC database.
        /// </summary>
        /// <param name="subcategory"></param>
        /// <returns></returns>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetSubcategoryInformationResult), 200)]
        public IActionResult GetSubcategoryInformation(
            [FromBody]GetSubcategoryInformation subcategory)
        {
            return Ok(new GetSubcategoryInformationResult
            {
                MessageHeader = subcategory.MessageHeader
            });
        }

        /// <summary>
        /// The Get UPC/PLU information function is an optional function that uses a message based system
        /// interface to provide the UPC/PLU information from the system maintaining the UPC/PLU information
        /// desired.
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetUpcPluInformationResult), 200)]
        public IActionResult GetUpcPluInformation(
            [FromBody]GetUpcPluInformation info)
        {
            return Ok(new GetUpcPluInformationResult
            {
                MessageHeader = info.MessageHeader
            });
        }

        /// <summary>
        /// The Generate APL List function is an optional function that uses a message based system interface to
        /// initiate the generation of the APL file.
        /// </summary>
        /// <param name="apl"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult GenerateAplFile (
            [FromBody]GenerateAplFile apl)
        {
            return Ok(apl.MessageHeader);
        }
    }
}