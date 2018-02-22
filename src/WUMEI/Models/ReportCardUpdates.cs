using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all paremeters required for the Report Card Updates method.
    /// </summary>
    public class ReportCardUpdates
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Collection of Detail Records for the Report Card Updates method.
        /// </summary>
        [Required]
        public IEnumerable<ReportCardUpdatesDetailRecords> DetailRecords { get; set; }
    }
}
