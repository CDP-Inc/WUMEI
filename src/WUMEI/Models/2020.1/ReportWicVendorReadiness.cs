using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Report WIC Vendor Readiness batch.
    /// </summary>
    public class ReportWicVendorReadiness
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader Header { get; set; }

        /// <summary>
        /// Collection of Detail Records for the Report WIC Vendor Readiness Batch.
        /// </summary>
        [Required]
        public IEnumerable<ReportWicVendorReadinessDetailRecord> Records { get; set; }
    }
}
