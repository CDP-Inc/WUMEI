using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Data element that is repeated for each food item in the purchase.
    /// </summary>
    [XmlRoot(ElementName = "FoodItem")]
    public class GetBenefitRedemptionHistoryResultFoodItem : V2018.GetBenefitRedemptionHistoryResultFoodItem
    {
        /// <summary>
        /// Gets or sets the name for a WIC food item.
        /// </summary>
        [Required]
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public override string ItemDescription { get; set; }

        /// <summary>
        /// Gets or sets the name for a WIC food item.
        /// </summary>
        [Required]
        [StringLength(4)]
        [RegularExpression(CustomRegex.Num)]
        public string ItemMessageReasonCode { get; set; }
    }
}
