using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Report Daily Oustanding Liability method.
    /// </summary>
    public class ReportDailyOutstandingLiability
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Collection of Detail Records for the Report Daily Outstanding Liability method.
        /// </summary>
        [Required]
        public IEnumerable<ReportDailyOutstandingLiabilityDetailRecords> DetailRecords { get; set; }
    }
}