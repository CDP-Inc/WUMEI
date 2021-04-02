using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// BenefitCategoryDetails Class (simply renames a few fields from the FoodBenefitBalance Class
    /// </summary>
    public class BenefitCategoryDetails : FoodBenefitBalance

    {
        /// <summary>
        /// Gets or sets category description. This property is not used in the 2020.1 interface definition
        /// </summary>
        [JsonIgnore]
        public override string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets category description. This property is not used in the 2020.1 interface definition
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a Category code
        /// as defined in the National UPC database.
        /// </summary>
        [JsonIgnore]
        public override string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a Category code
        /// as defined in the National UPC database.
        /// </summary>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string SubCategoryCode { get; set; }

        /// <summary>
        /// Gets or sets long description of the Sub-Category code.
        /// This property is not used in the 2020.1 interface definition
        /// </summary>
        [JsonIgnore]
        public override string SubcategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets long description of the Sub-Category code.
        /// This property is not used in the 2020.1 interface definition
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string SubCategoryDescription { get; set; }

    }
}

