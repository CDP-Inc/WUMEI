﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters for the Update WIC Vendor Banking Information method.
    /// </summary>
    public class UpdateWicVendorBankingInformation
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the number that identifies the financial institution to which a WIC Vendor is paid
        /// via ACH and conforms to the American Bankers Association standard.
        /// </summary>
        [Required, StringLength(9, MinimumLength = 9)]
        [RegularExpression(CustomRegex.Num)]
        public string AbaRoutingTransitNumber { get; set; }

        /// <summary>
        /// Gets or sets the ACH cutoff time set by the WIC EBT processor for the WIC Vendor
        /// </summary>
        public DateTime AchSettlementTime { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        [Required, StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets the business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcSpecSpace)]
        public virtual string BankName { get; set; }

        /// <summary>
        /// Gets or sets the number identifying the WIC Vendor's bank checking account.
        /// </summary>
        [Required]
        [Range(typeof(long), "0", "99999999999999999")]
        public long BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the status of the entity indicated.
        /// </summary>
        /// <remarks>Indicates result, Activated, Deactivated, etc</remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets value assigned by the WIC Management Information System to idenfity the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required, StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }

        /// <summary>
        /// Gets or sets a value identifying the federal and/or state tax identification number assigned
        /// to the WIC Vendor.
        /// </summary>
        /// <remarks>
        /// Required if required by the WIC State Agency compliance requirements.
        /// </remarks>
        [Range(typeof(int), "0", "999999999")]
        public int WicVendorTaxId { get; set; }
    }
}