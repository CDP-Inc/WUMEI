using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Data element that contains all sub-elements that are repeated and returned for each matching authorization
    /// for the Get Warehouse Authorizations method.
    /// </summary>
    public class WarehouseAuthorizations
    {
        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the 
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Required, StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }

        /// <summary>
        /// First date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BeginBenefitDate { get; set; }

        /// <summary>
        /// Last date on which benefits may be used expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime EndBenefitDate { get; set; }

        /// <summary>
        /// Information identifying the UPC or PLU assigned to a food item;
        /// see Technical Implementation Guide for formatting.
        /// </summary>
        /// <remarks>
        /// Contains UPC/PLU indicator, UPC/PLU and UPC/PLU check digit
        /// </remarks>
        [Required, StringLength(17)]
        [RegularExpression(CustomRegex.Num)]
        public string UpcPluData { get; set; }

        /// <summary>
        /// Indicate the number of significant digits in the UPC or PLU
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "15")]
        public byte UpcPluDataLength { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        [Required, StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Value assigned by the WIC Management Information System to idenfity the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required, StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }

        /// <summary>
        /// The quantity of a given product that has been authorized but not yet redeemed.
        /// </summary>
        /// <remarks>
        /// Depleted authorizations are returned.
        /// </remarks>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal AvailableAuthorizationQuantity { get; set; }

        /// <summary>
        /// The aggregate quantity of a given product that was originally authorized.
        /// </summary>
        /// <remarks>
        /// Sum of all requests.
        /// </remarks>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal OriginalAuthorizationQuantity { get; set; }
    }
}