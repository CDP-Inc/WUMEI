using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class FoodBenefitBalance
    {
        /// <summary>
        /// The quantity of a food item defined in the sender's specified benefit issuance unit of measure.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Num)]
        public decimal BenefitQuantity { get; set; }

        /// <summary>
        /// A code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// A literal describing the Category code as specified by the originatiing WIC authority suitable
        /// for printing or displaying in areas where display width is not a concern.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string CategoryLongDescription { get; set; }

        /// <summary>
        /// A code further identifying the type of product within a Category code
        /// as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// A long description of the Sub-Category code suitable for printing or displaying
        /// in areas where display width is not a concern.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string SubcategoryLongDescription { get; set; }
    }
}
