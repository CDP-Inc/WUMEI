using System;
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
        public BatchRecordHeader RecordHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Accepted values are add or update.
        /// </remarks>
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets a text description of the originator's specified benefit issuance unit of measure
        /// e.g. can, pkg, jar
        /// </summary>
        public string BenefitUnitDescription { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the national UPC database.
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a description of the category code as specified by the originating WIC authority suitable
        /// for printing or displaying in areas where display width is not a concern.
        /// </summary>
        public string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets a description of the category code suitable for displaying on screen and reports where
        /// display of width is a concern.
        /// </summary>
        public string CategoryShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the date for which the category code shall become available for use expressed
        /// in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public string BeginCategoryDate { get; set; }

        /// <summary>
        /// Gets or sets the date for which the subcategory code shall become available for use expressed
        /// int GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public string BeginSubcategoryDate { get; set; }

        /// <summary>
        /// Gets or sets the last date for which the category code shall be used expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public string EndCategoryDate { get; set; }

        /// <summary>
        /// Gets or sets the last date for which the subcategory code shall be used expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public string EndSubcategoryDate { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a category code
        /// as defined in the national UPC database.
        /// </summary>
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a long description of the subcategory code suitable for printing or displaying
        /// in areas where display width is not a concern.
        /// </summary>
        public string SubcategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets a short description of the subcategory code suitable for printing or displaying in areas
        /// (particularly POS stand-beside receipts) where display width is a concern.
        /// </summary>
        /// <remarks>
        /// From the subcategory description data element in the UPC/PLU data file.
        /// </remarks>
        public string SubcategoryShortDescription { get; set; }
    }
}