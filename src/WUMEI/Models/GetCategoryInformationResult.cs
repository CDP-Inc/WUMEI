using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters that are returned for the Get Category Information Result method.
    /// </summary>
    public class GetCategoryInformationResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Data element that returns all available categories.
        /// </summary>
        [Required]
        public IEnumerable<CategoryInformation> CategoryInformation { get; set; }
    }
}