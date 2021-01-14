using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Objects of this class will hold the results of GetSubcategoryInformation method
    /// </summary>
    public class GetSubcategoryInformationResult
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the list of subcategory information
        /// </summary>
        public List<SubcategoryInformation> SubcategoryInformation { get; set; }
    }
}
