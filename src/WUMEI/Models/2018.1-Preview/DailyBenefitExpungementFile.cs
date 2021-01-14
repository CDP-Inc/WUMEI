using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    ///  A data object which represents a deserialized WUMEI benefit purge file
    /// </summary>
    public class DailyBenefitExpungementFile
    {
        /// <summary>
        /// Gets or sets the data from the batch file header
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Gets or sets a list containing the benefit expungement records contained within the data file
        /// </summary>
        [Required]
        public IEnumerable<DailyBenefitExpungementRecord> Records { get; set; }
    }
}
