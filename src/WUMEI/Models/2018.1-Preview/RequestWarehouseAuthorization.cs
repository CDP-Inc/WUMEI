﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters required for the Request Warehouse Authorization method. 
    /// </summary>
    public class RequestWarehouseAuthorization
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the quantity of products that have been requested by a warehouse vendor for the purpose of
        /// a warehouse authorization.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal AuthorizationQuantity { get; set; }

        /// <summary>
        /// Gets or sets a series of digits appearing on the face of the WIC Card or encoded on the 
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        /// <remarks>
        /// Required if WIC MIS account ID not present.
        /// </remarks>
        [StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets first date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Begin date of the benefit that will be utilized in the redemption.
        /// </remarks>
        [Required]
        public DateTime BeginBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets last date on which benefits may be used expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// End date of the benefit that will be utilized in the redemption.
        /// </remarks>
        [Required]
        public DateTime EndBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets information identifying the UPC or PLU assigned to a food item;
        /// see Technical Implementation Guide for formatting.
        /// </summary>
        /// <remarks>
        /// Contains UPC/PLU indicator, UPC/PLU and UPC/PLU check digit
        /// </remarks>
        [Required, StringLength(17)]
        [RegularExpression(CustomRegex.Num)]
        public string UpcPluData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the number of significant digits in the UPC or PLU
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "15")]
        public byte UpcPluDataLength { get; set; }

        /// <summary>
        /// Gets or sets value assigned by the WIC MIS to identify an account for a WIC participant,
        /// economic unit or household.
        /// </summary>
        /// <remarks>
        /// Required if Card number not present.
        /// </remarks>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Gets or sets value assigned by the WIC Management Information System to identify the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required, StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }
    }
}