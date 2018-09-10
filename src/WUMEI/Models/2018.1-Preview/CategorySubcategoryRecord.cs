using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object which provides a deserialization target for the JSON data in a category/subcategory file record.
    /// </summary>
    public class CategorySubcategoryRecord
    {
        /// <summary>
        /// Gets or sets an object identifying a record and carrying metadata about it.
        /// </summary>
        [Required]
        public BatchRecordHeader RecordHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Accepted values are add or update.
        /// </remarks>
        [Required]
        [Range(typeof(short), "0", "999")]
        public short ActionCode { get; set; }

        /// <summary>
        /// Gets or sets a text description of the originator's specified benefit issuance unit of measure
        /// e.g. can, pkg, jar
        /// </summary>
        [Required]
        [StringLength(6, MinimumLength = 1)]
        public string BenefitUnitDescription { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the national UPC database.
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "99")]
        public byte CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a description of the category code as specified by the originating WIC authority suitable
        /// for printing or displaying in areas where display width is not a concern.
        /// </summary>
        [StringLength(50, MinimumLength = 1)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets a description of the category code suitable for displaying on screen and reports where
        /// display of width is a concern.
        /// </summary>
        [Required]
        [StringLength(20, MinimumLength = 1)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string CategoryShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the date for which the category code shall become available for use expressed
        /// in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginCategoryDate { get; set; }

        /// <summary>
        /// Gets or sets the date for which the subcategory code shall become available for use expressed
        /// int GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginSubcategoryDate { get; set; }

        /// <summary>
        /// Gets or sets the last date for which the category code shall be used expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndCategoryDate { get; set; }

        /// <summary>
        /// Gets or sets the last date for which the subcategory code shall be used expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndSubcategoryDate { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a category code
        /// as defined in the national UPC database.
        /// </summary>
        [Required]
        [Range(typeof(short), "0", "999")]
        public short SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a long description of the subcategory code suitable for printing or displaying
        /// in areas where display width is not a concern.
        /// </summary>
        [StringLength(50, MinimumLength = 1)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string SubcategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets a short description of the subcategory code suitable for printing or displaying in areas
        /// (particularly POS stand-beside receipts) where display width is a concern.
        /// </summary>
        /// <remarks>
        /// From the subcategory description data element in the UPC/PLU data file.
        /// </remarks>
        [Required]
        [StringLength(20, MinimumLength = 1)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string SubcategoryShortDescription { get; set; }
    }
}