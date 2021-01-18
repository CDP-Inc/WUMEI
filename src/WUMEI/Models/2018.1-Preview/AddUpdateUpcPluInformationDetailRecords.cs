using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Collection of Detail Records for the Add Update UPC PLU Information method.
    /// </summary>
    public class AddUpdateUpcPluInformationDetailRecords
    {
        /// <summary>
        /// Gets or sets an object identifying a record and carrying metadata about it.
        /// </summary>
        public BatchRecordHeader RecordHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Add or Update.
        /// </remarks>
        [Required, StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets the quantity of a food item returned that maps to our exchange size.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal BenefitQuantity { get; set; }

        /// <summary>
        /// Gets or sets the text description of the originator's specified benefit issuance unit of measure
        /// e.g. can, pkg, jar
        /// </summary>
        /// <remarks>
        /// Only first 6 characters are significant.
        /// </remarks>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpec)]
        public virtual string BenefitUnitDescription { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the date for which the UPC/PLU data shall
        /// become available for use expressed in
        /// GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginUpcPluData { get; set; }

        /// <summary>
        /// Gets or sets the last date for which the UPC/PLU data shall be used expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndUpcPluData { get; set; }

        /// <summary>
        /// Gets or sets a name for a WIC food item.
        /// </summary>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string ItemDescription { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if a food item is allowed
        /// for purchase with a manual voucher.
        /// </summary>
        [Range(typeof(byte), "0", "1")]
        public byte ManualVoucherIndicator { get; set; }

        /// <summary>
        /// Gets or sets the level to be used for calculation of NTE.
        /// </summary>
        /// <remarks>
        /// Required if provided in Add or Update UPC/PLU Information.
        /// S = Sub-category, U = UPC.
        /// </remarks>
        [StringLength(1, MinimumLength = 1)]
        [RegularExpression(CustomRegex.Abc)]
        public string NteCalculationIndicator { get; set; }

        /// <summary>
        /// Gets or sets the number of iterations of APL type in the UPC/PLU record.
        /// </summary>
        [Range(typeof(short), "0", "9999")]
        public virtual short NumberOfAplTypes { get; set; }

        /// <summary>
        /// Gets or sets the number of iterations of WIC Vendor peer groups and NTE prices for those groups.
        /// </summary>
        /// <remarks>
        /// Identifies how many WIC Vendor peer group IDs are included in the repeating section below.
        /// </remarks>
        [Required]
        [Range(typeof(byte), "0", "99")]
        public virtual byte NumberOfWicVendorPeerGroups { get; set; }

        /// <summary>
        /// Gets or sets the size of the contents of the package quantified in the standard benefit units of measure.
        /// </summary>
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal PackageSize { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the kind of price being sent in the record.
        /// X9.93:1 for values.
        /// </summary>
        [Required, StringLength(2, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string PriceType { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating a food item that can be purchased with benefits assigned in a
        /// non-zero Sub-Category code(any Subcategory code that is not equal to “000”)
        /// as well as with benefits assigned in the Broadband Sub-Category code.
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "1")]
        public byte PurchaseIndicator { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating that a food item is eligible for rebate to the WIC State Agency.
        /// </summary>
        /// <remarks>
        /// Identifies whether a food item is eligible for manufacturer rebates;
        /// values are "0" for no, "1" for yes.
        /// </remarks>
        [Required]
        [Range(typeof(byte), "0", "1")]
        public byte RebateFlag { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a Category code 
        /// as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the information identifying the UPC or PLU assigned to a food item;
        /// see Technical Implementation Guide for formatting.
        /// </summary>
        /// <remarks>
        /// Contains UPC/PLU indicator, UPC/PLU and UPC/PLU check digit
        /// </remarks>
        [Required]
        public UpcPluObject UpcPluData { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element containing elements repeated for each
        /// UPC/PLU data data element where an NTE price is provided.
        /// </summary>
        [Required]
        public virtual IEnumerable<NtePriceAndWicVendorPeerGroupId> NtePriceWicVendorPeerGroupId { get; set; }

        /// <summary>
        /// Gets or sets the type of APL That is assigned to a vendor and contains only products that
        /// are assigned to the APL type. Is repeated for each UPC/PLU data data element.
        /// </summary>
        public IEnumerable<AplTypes> AplTypes { get; set; }
    }
}