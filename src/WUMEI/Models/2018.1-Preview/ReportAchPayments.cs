using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Report ACH Payments method.
    /// </summary>
    public class ReportAchPayments
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Collection of Detail Records for the Report ACH Payments method.
        /// </summary>
        [Required]
        public IEnumerable<ReportAchPaymentsDetailRecords> DetailRecords { get; set; }
    }
}
