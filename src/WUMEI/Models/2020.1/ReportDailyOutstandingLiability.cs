﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WUMEI.Models.V2018;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Report Daily Outstanding Liability method.
    /// </summary>
    public class ReportDailyOutstandingLiability
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader Header { get; set; }

        /// <summary>
        /// Gets or sets a collection of Detail Records for the Report Daily Outstanding Liability method.
        /// </summary>
        [Required]
        public IEnumerable<ReportDailyOutstandingLiabilityDetailRecords> Records { get; set; }
    }
}