using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Data element that is repeated for each WIC MIS account ID.
    /// </summary>
    public class GetBenefitBalanceResultBenefitBalance
    {
        /// <summary>
        /// A Unique number identifying a benefit issuance; Assigned by the WIC MIS system.
        /// </summary>
        /// <remarks>
        /// Required if requested.
        /// </remarks>
        [Range(typeof(long), "0", "999999999999")]
        [RegularExpression(CustomRegex.AbcNum)]
        public long? BenefitIssuanceId { get; set; }

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
        /// A Generic IEnumerable of objects containing details of the food benefit balance of
        /// each food item perscribed to the household.
        /// </summary>
        [Required]
        public IEnumerable<GetBenefitBalanceResultFoodBenefitBalance> FoodBenefitBalance { get; set; }
    }
}
