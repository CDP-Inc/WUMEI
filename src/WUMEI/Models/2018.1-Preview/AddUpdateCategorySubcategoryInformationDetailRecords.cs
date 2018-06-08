using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Collection of Detail Records for the Add Update Category Subcategory Information method.
    /// </summary>
    public class AddUpdateCategorySubcategoryInformationDetailRecords
    {
        /// <summary>
        /// A code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Add or Update.
        /// </remarks>
        [Required, StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

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
        /// <remarks>
        /// Category code of the benefit applied to the food item.
        /// </remarks>
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
        /// A short literal describing the Category code suitable for displaying on screen and reports where
        /// display of width is a concern.
        /// </summary>
        [Required, StringLength(20)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string CategoryShortDescription { get; set; }

        /// <summary>
        /// The date for which the Category code
        /// shall become available for use expressed
        /// in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime BeginCategoryDate { get; set; }

        /// <summary>
        /// The date for which the Sub-Category code
        /// shall become available for use expressed
        /// int GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime BeginSubcategoryDate { get; set; }

        /// <summary>
        /// The last date for which the Category code
        /// shall be used expressed in GMT in 
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EndCategoryDate { get; set; }

        /// <summary>
        /// The last date for which the Sub-Category
        /// code shall be used expressed in GMT in 
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
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
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string SubcategoryLongDescription { get; set; }

        /// <summary>
        /// A short description of the Sub-Category
        /// code suitable for printing or displaying in areas
        /// (particularly POS stand-beside receipts) where display width is a concern.
        /// </summary>
        /// <remarks>
        /// From the Subcategory description data element in the UPC/PLU data file.
        /// </remarks>
        [Required, StringLength(24)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string SubcategoryShortDescription { get; set; }
    }
}