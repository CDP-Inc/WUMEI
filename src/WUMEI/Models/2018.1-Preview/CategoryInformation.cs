using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Data elements containing information for Subcategories that is returned when the
    /// Get Category Information method is called.
    /// </summary>
    public class CategoryInformation
    {
        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the National UPC database.
        /// </summary>
        [Required, StringLength(2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a literal describing the Category code as specified by the originating WIC authority suitable
        /// for printing or displaying in areas where display width is not a concern.
        /// </summary>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets a short literal describing the Category code suitable for displaying on screen and reports
        /// where display of width is a concern.
        /// </summary>
        [Required, StringLength(20)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string CategoryShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the date for which the Category code
        /// shall become available for use expressed
        /// in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BeginCategoryDate { get; set; }

        /// <summary>
        /// Gets or sets the last date for which the Category code
        /// shall be used expressed in GMT in 
        /// accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime EndCategoryDate { get; set; }
    }
}
