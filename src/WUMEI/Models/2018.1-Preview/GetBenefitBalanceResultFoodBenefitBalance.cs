using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Data element containing needed repeated data for each Benefit issuance ID or date range.
    /// </summary>
    public class GetBenefitBalanceResultFoodBenefitBalance
    {
        /// <summary>
        /// The quantity of a food item defined in the sender's specified benefit issuance unit of measure in
        /// active hold at a WIC Vendor for manual voucher authorization.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Num)]
        public decimal BenefitQuantityActiveHold { get; set; }

        /// <summary>
        /// The quantity of a food item defined in the sender's specified benefit issuance unit
        /// of measure available for purchase.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Num)]
        public decimal BenefitQuantityAvailable { get; set; }

        /// <summary>
        /// A code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// A code further identifying the type of product within a Category code 
        /// as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string SubcategoryCode { get; set; }
    }
}
