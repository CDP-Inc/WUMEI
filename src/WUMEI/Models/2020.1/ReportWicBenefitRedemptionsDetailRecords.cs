using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Collection of Detail Records for the Report WIC Benefit Redemptions method.
    /// </summary>
    public class ReportWicBenefitRedemptionsDetailRecords : V2018.BenefitRedemptionTransactionRecord
    {
        /// <summary>
        /// Gets or sets a data element that is repeated for each food item in the purchase.
        /// </summary>
        public new IEnumerable<GetBenefitRedemptionHistoryResultFoodItem> FoodBenefitBalance { get; set; }

    }
}