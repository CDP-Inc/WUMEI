using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    ///  Food benefit balance class
    /// </summary>
    public class FoodBenefitBalance
    {
        /// <summary>
        /// Gets or sets the quantity of a food item defined in the sender's specified benefit issuance unit of measure.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal BenefitQuantity { get; set; } = -1M;

        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required]
        [StringLength(2, MinimumLength = 2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a literal describing the Category code as specified by the originating WIC authority suitable
        /// for printing or displaying in areas where display width is not a concern.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public virtual string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a Category code
        /// as defined in the National UPC database.
        /// </summary>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets long description of the Sub-Category code suitable for printing or displaying
        /// in areas where display width is not a concern.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public virtual string SubcategoryLongDescription { get; set; }
    }
}
