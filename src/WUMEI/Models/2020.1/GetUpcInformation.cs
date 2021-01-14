using System.ComponentModel.DataAnnotations;
using WUMEI.Models.V2018;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// The input model for the GetUpcInformation function
    /// </summary>
    ///
    public class GetUpcInformation
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets an object that represents UPC or PLU data.
        /// </summary>
        [Required]
        public UpcPluObject UpcPluData { get; set; }
    }
}
