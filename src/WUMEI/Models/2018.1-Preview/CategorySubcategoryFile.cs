using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models
{
    /// <summary>
    /// A data object which represents a deserialized WUMEI category/subcategory file.
    /// </summary>
    public class CategorySubcategoryFile
    {
        /// <summary>
        /// Gets or sets the data from the batch file header.
        /// </summary>
        public BatchHeader Header { get; set; }

        /// <summary>
        /// Gets or sets a list containing the cat/subcat records contained within the data file.
        /// </summary>
        public List<CategorySubcategoryRecord> Records { get; set; }
    }
}
