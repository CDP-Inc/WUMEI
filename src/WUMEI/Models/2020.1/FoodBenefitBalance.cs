using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{

    /// <summary>
    ///  Food benefit balance class
    /// </summary>
    public class FoodBenefitBalance : V2018.FoodBenefitBalance
    {
        /// <summary>
        /// Gets or sets category description. This property is not used in the 2020.1 interface definition
        /// </summary>
        [JsonIgnore]
        public override string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets long description of the Sub-Category code.
        /// This property is not used in the 2020.1 interface definition
        /// </summary>
        [JsonIgnore]
        public override string SubcategoryLongDescription { get; set; }
    }
}
