using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Data element containing needed repeated data for each Benefit issuance ID or date range.
    /// </summary>
    public class GetBenefitBalanceResultFoodBenefitBalance
    {
        /// <summary>
        /// Gets or sets the quantity of a food item defined in the sender's specified benefit issuance unit of 
        /// measure in active hold at a WIC Vendor for manual voucher authorization.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Num)]
        public decimal BenefitQuantityActiveHold { get; set; }

        /// <summary>
        /// Gets or sets the quantity of a food item defined in the sender's specified benefit issuance unit
        /// of measure available for purchase.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Num)]
        public decimal BenefitQuantityAvailable { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required]
        [Range(0, 99)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a Category code
        /// as defined in the National UPC database.
        /// </summary>
        [Required]
        [Range(0, 999)]
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the benefit record was created
        /// </summary>
        /// <remarks>
        /// This will be used for determining which benefit was issued first so that we know which to decrease
        /// first while processing the benefit balance for a smart card.
        /// NOTE: This property will not be returned in the result.
        /// </remarks>
        [JsonIgnore]
        public DateTime SetupDate { get; set; }
    }
}
