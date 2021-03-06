﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters that are returned for the Get Subcategory Information method.
    /// </summary>
    public class GetSubcategoryInformationResult
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a data element that returns all available subcategories.
        /// </summary>
        [Required]
        public IEnumerable<SubcategoryInformation> SubcategoryInformaton { get; set; }
    }
}