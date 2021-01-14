using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters for the Get Warehouse Authorizations method.
    /// </summary>
    public class GetWarehouseAuthorizations
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a series of digits appearing on the face of the WIC Card or encoded on the 
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        /// <remarks>
        /// Required if the UPC/PLU data, WIC MIS account ID, and WICMIS WIC vendor ID filters are not present.
        /// </remarks>
        [StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets first date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        public DateTime BeginBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets last date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        public DateTime EndBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets information identifying the UPC or PLU assigned to a food item;
        /// see Technical Implementation Guide for formatting.
        /// </summary>
        /// <remarks>
        /// Contains UPC/PLU indicator, UPC/PLU and UPC/PLU check digit.
        /// Required if the Card number, WIC MIS account ID, and WIC MIS WIC vendor ID filters are not present.
        /// </remarks>
        [StringLength(17)]
        [RegularExpression(CustomRegex.Num)]
        public string UpcPluData { get; set; }

        /// <summary>
        /// Gets or sets a value to indicate the number of significant digits in the UPC or PLU
        /// </summary>
        /// <remarks>
        /// Required if UPC/PLU data is present.
        /// </remarks>
        [Range(typeof(byte), "0", "15")]
        public byte UpcPluDataLength { get; set; }

        /// <summary>
        /// Gets or sets a value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        /// <remarks>
        /// Required if the Card number, UPC/PLU data, and WICMIS WIC vendor ID filters are not present.
        /// </remarks>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Gets or sets a value assigned by the WIC Management Information System to identify the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        /// <remarks>
        /// Required if the Card number, UPC/PLU data, and WIC MIS account ID filters are not present.
        /// </remarks>
        [StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }
    }
}