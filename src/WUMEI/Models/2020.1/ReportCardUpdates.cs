﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Report Card Updates method.
    /// </summary>
    public class ReportCardUpdates
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader Header { get; set; }

        /// <summary>
        /// Gets or sets a collection of Detail Records for the Report Card Updates method.
        /// </summary>
        [Required]
        public IEnumerable<ReportCardUpdatesDetailRecords> Records { get; set; }
    }
}
