using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters required for the Report WIC Benefit Month Data method.
    /// </summary>
    public class ReportWicBenefitMonthData
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Gets or sets a collection of Detail Records for the Report WIC Benefit Month Data method.
        /// </summary>
        [Required]
        public IEnumerable<ReportWicBenefitMonthDataDetailRecords> DetailRecords { get; set; }
    }
}
