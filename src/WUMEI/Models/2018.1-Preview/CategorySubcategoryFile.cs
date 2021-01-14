using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// A data object which represents a deserialized WUMEI category/subcategory file.
    /// </summary>
    public class CategorySubcategoryFile
    {
        /// <summary>
        /// Gets or sets the data from the batch file header.
        /// </summary>
        [Required]
        public BatchHeader Header { get; set; }

        /// <summary>
        /// Gets or sets a list containing the cat/subcat records contained within the data file.
        /// </summary>
        public List<CategorySubcategoryRecord> Records { get; set; }
    }
}
