using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Data element that is repeated for each WIC MIS account ID.
    /// </summary>
    public class GetBenefitBalanceResultBenefitBalance
    {
        /// <summary>
        /// Gets or sets a Unique number identifying a benefit issuance; Assigned by the WIC MIS system.
        /// </summary>
        /// <remarks>
        /// Required if requested.
        /// </remarks>
        [Range(typeof(long), "0", "999999999999")]
        [RegularExpression(CustomRegex.AbcNum)]
        public long? BenefitIssuanceId { get; set; }

        /// <summary>
        /// Gets or sets the first date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets the last date on which benefits may be used expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets a Generic IEnumerable of objects containing details of the food benefit balance of
        /// each food item prescribed to the household.
        /// </summary>
        [Required]
        public IEnumerable<GetBenefitBalanceResultFoodBenefitBalance> FoodBenefitBalance { get; set; }
    }
}
