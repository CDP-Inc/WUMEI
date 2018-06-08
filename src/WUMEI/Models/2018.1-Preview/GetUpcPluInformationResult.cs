using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters returned for the Get UPC/PLU Information method.
    /// </summary>
    public class GetUpcPluInformationResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// The quantity of a food item returned that maps to our exchange size.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Num)]
        public decimal BenefitQuantity { get; set; }

        /// <summary>
        /// Text description of the originator's specified benefit issuance unit of measure
        /// e.g. can, pkg, jar
        /// </summary>
        /// <remarks>
        /// Only first 6 characters are significant.
        /// </remarks>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpec)]
        public string BenefitUnitDescription { get; set; }

        /// <summary>
        /// A code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// A literal describing the Category code as specified by the originatiing WIC authority suitable
        /// for printing or displaying in areas where display width is not a concern.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string CategoryLongDescription { get; set; }

        /// <summary>
        /// A short literal describing the Category code suitable for displaying on screen and reports where
        /// display of width is a concern.
        /// </summary>
        [StringLength(20)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string CategoryShortDescription { get; set; }

        /// <summary>
        /// The date for which the Category code
        /// shall become available for use expressed
        /// in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BeginCategoryDate { get; set; }

        /// <summary>
        /// The date for which the Sub-Category code
        /// shall become available for use expressed
        /// int GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BeginSubcategoryDate { get; set; }

        /// <summary>
        /// The date for which the UPC/PLU data shall
        /// become available for use expressed in
        /// GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BeginUpcPluData { get; set; }

        /// <summary>
        /// The last date for which the Category code
        /// shall be used expressed in GMT in 
        /// accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime EndCategoryDate { get; set; }

        /// <summary>
        /// The last date for which the Sub-Category
        /// code shall be used expressed in GMT in 
        /// accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime EndSubcategoryDate { get; set; }

        /// <summary>
        /// The last date for which the UPC/PLU data shall be used expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime EndUpcPluData { get; set; }

        /// <summary>
        /// A name for a WIC food item.
        /// </summary>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string ItemDescription { get; set; }

        /// <summary>
        /// A flag indicating if a food item is allowed
        /// for purchase with a manual voucher.
        /// </summary>
        [Range(typeof(byte), "0", "1")]
        public byte ManualVoucherIndicator { get; set; }

        /// <summary>
        /// Identifies level to be used for calculation of NTE.
        /// </summary>
        /// <remarks>
        /// Required if provided in Add or Update UPC/PLU Information.
        /// S = Sub-category, U = UPC.
        /// </remarks>
        [StringLength(1, MinimumLength = 1)]
        [RegularExpression(CustomRegex.Abc)]
        public string NteCalculationIndicator { get; set; }

        /// <summary>
        /// Number of iterations of WIC Vendor peer groups and NTE prices for those groups.
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "99")]
        public byte NumberOfWicVendorPeerGroups { get; set; }

        /// <summary>
        /// The size of the contents of the package quantified in the standard benefit units of measure.
        /// </summary>
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal PackageSize { get; set; }

        /// <summary>
        /// A code indicating the kind of price being sent in the record.
        /// X9.93:1 for values.
        /// </summary>
        [Required, StringLength(2, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string PriceType { get; set; }

        /// <summary>
        /// A flag indicating a food item that can be purchased with benefits assigned in a
        /// non-zero Sub-Category code(any Subcategory code that is not equal to “000”)
        /// as well as with benefits assigned in the Broadband Sub-Category code.
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "1")]
        public byte PurchaseIndicator { get; set; }

        /// <summary>
        /// A flag indicating that a food item is eligible for rebate to the WIC State Agency.
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "1")]
        public byte RebateFlag { get; set; }

        /// <summary>
        /// A code further identifying the type of product within a Category code 
        /// as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// A long description of the Sub-Category code suitable for printing or displaying
        /// in areas where display width is not a concern.
        /// </summary>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string SubcategoryLongDescription { get; set; }

        /// <summary>
        /// A short description of the Sub-Category
        /// code suitable for printing or displaying in areas
        /// (particularly POS stand-beside receipts) where display width is a concern.
        /// </summary>
        [Required, StringLength(24)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string SubcategoryShortDescription { get; set; }

        /// <summary>
        /// Information identifying the UPC or PLU assigned to a food item;
        /// see Technical Implementation Guide for formatting.
        /// </summary>
        /// <remarks>
        /// Contains UPC/PLU indicator, UPC/PLU and UPC/PLU check digit
        /// </remarks>
        [StringLength(17)]
        [RegularExpression(CustomRegex.Num)]
        public string UpcPluData { get; set; }

        /// <summary>
        /// Indicate the number of significant digits in the UPC or PLU
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "15")]
        public byte UpcPluDataLength { get; set; }

        /// <summary>
        /// The following data elements are repeated for each UPC/PLU data data element where there is more
        /// than one WIC Vendor peer group ID and NTE price associated with the UPC/PLU data:
        /// </summary>
        public IEnumerable<NtePriceAndWicVendorPeerGroupId> NtePriceAndWicVendorPeerGroupId { get; set; }
    }
}