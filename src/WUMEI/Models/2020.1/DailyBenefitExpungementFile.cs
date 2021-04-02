using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WUMEI.Models.V2018;

namespace WUMEI.Models.V2020
{
    /// <summary>
    ///  A data object which represents a deserialized WUMEI benefit purge file
    /// </summary>
    public class DailyBenefitExpungementFile : V2018.DailyBenefitExpungementFile
    {
        /// <summary>
        /// Gets or sets the data from the batch file header
        /// </summary>
        [Required]
        public new BatchHeader Header { get; set; }
    }
}
