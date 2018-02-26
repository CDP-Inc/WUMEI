using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Data elements containing information for Subcategories that is returned when the
    /// Get Subcategory Information method is called.
    /// </summary>
    public class SubcategoryInformation
    {
        /// <summary>
        /// Text description of the originator's specified benefit issuance unit of measure
        /// e.g. can, pkg, jar
        /// </summary>
        /// <remarks>
        /// Only first 6 characters are significant.
        /// </remarks>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpec)]
        public string BenefitUnitDescription { get; set; }

        /// <summary>
        /// A code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// The date for which the Sub-Category code
        /// shall become available for use expressed
        /// int GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BeginSubcategoryDate { get; set; }

        /// <summary>
        /// The last date for which the Sub-Category
        /// code shall be used expressed in GMT in 
        /// accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime EndSubcategoryDate { get; set; }

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
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string SubcategoryLongDescription { get; set; }

        /// <summary>
        /// A short description of the Sub-Category
        /// code suitable for printing or displaying in areas
        /// (particularly POS stand-beside receipts) where display width is a concern.
        /// </summary>
        [Required, StringLength(24)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string SubcategoryShortDescription { get; set; }
    }
}