using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Contains the data elements that are repeated for each current and future Sub-Category code within
    /// each Category code for the Report Daily Outstanding Liability method.
    /// </summary>
    public class OustandingLiabilities
    {
        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a Category code as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the quantity of a food item defined in the sender's specified benefit issuance unit of measure.
        /// </summary>
        /// <remarks>
        /// The total quantity of benefits for the reported Sub-Category with the Category.
        /// </remarks>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal BenefitQuantity { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// I = current benefit issuance; F = future benefit issuance.
        /// </remarks>
        [Required, StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }
    }
}