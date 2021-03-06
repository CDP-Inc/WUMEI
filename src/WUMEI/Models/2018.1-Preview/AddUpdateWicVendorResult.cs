﻿using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters returned for the Add Update WIC Vendor method.
    /// </summary>
    public class AddUpdateWicVendorResult
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the status of the entity indicated.
        /// </summary>
        /// <remarks>
        /// Indicates result, Activated, Deactivated, etc.
        /// Default is "A001 - activated."
        /// </remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string StatusCode { get; set; }
    }
}
