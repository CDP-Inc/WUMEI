using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Add update benefits benefit balance
    /// </summary>
    public class AddUpdateBenefitsBenefitBalance : V2018.AddUpdateBenefitsBenefitBalance
    {
        /// <summary>
        /// Gets or sets data element repeated for each food item in the purchase.
        /// </summary>
        [Required]
        public new IEnumerable<FoodBenefitBalance> FoodBenefitBalance { get; set; }

    }
}
