using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains data elements that are repeated for each Category and Subcategory in the household
    /// account during the Benefit month specified for the Report Wic Benefit Month Data method.
    /// </summary>
    public class BenefitQuantityInformation
    {
        /// <summary>
        /// Gets or sets the quantity of a food item defined in the sender's specified benefit issuance unit of measure
        /// that have passed the last day to spend.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "99999")]
        public decimal ExpiredBenefitQuantity { get; set; }

        /// <summary>
        /// Gets or sets the quantity of a food item defined in the sender's specified benefit issuance
        /// unit of measure issued.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "99999")]
        public decimal IssuedBenefitQuantity { get; set; }

        /// <summary>
        /// Gets or sets the quantity of a food item defined in the sender's specified benefit issuance unit
        /// of measure redeemed in a purchase.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "99999")]
        public decimal RedeemedBenefitQuantity { get; set; }

        /// <summary>
        /// Gets or sets the quantity of a food item defined in the sender's specified benefit issuance unit
        /// of measure that has been voided.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "99999")]
        public decimal VoidedByWicMisBenefitQuantity { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a Category code
        /// as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string SubcategoryCode { get; set; }
    }
}