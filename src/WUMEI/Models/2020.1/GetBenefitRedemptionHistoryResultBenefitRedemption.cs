using System.Collections.Generic;
using System.Xml.Serialization;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Data element that is repeated for each purchase return by GetBenefitRedemptionHistory.
    /// </summary>
    [XmlRoot(ElementName = "BenefitRedemption")]
    public class GetBenefitRedemptionHistoryResultBenefitRedemption
        : V2018.GetBenefitRedemptionHistoryResultBenefitRedemption
    {
        /// <summary>
        /// Gets or sets the data element that is repeated for each food item in the purchase.
        /// </summary>
        public new List<GetBenefitRedemptionHistoryResultFoodItem> BenefitRedemptionFoodItems { get; set; }
    }
}
