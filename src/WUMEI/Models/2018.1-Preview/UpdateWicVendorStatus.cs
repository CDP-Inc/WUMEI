﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters for the Update WIC Vendor Status method.
    /// </summary>
    public class UpdateWicVendorStatus
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Update, Hold, Deactive, or Reactivate.
        /// </remarks>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets reason for an action.
        /// </summary>
        [Required]
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the status of the entity indicated.
        /// </summary>
        /// <remarks>
        /// New status code (Activated, On hold).
        /// </remarks>
        [Required]
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets value assigned by the WIC Management Information System to identify the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required]
        [StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }
    }
}