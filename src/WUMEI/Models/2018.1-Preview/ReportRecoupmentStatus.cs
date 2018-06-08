using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters for the Report Recoupment Status method.
    /// </summary>
    public class ReportRecoupmentStatus
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Collection of Detail Records for the Report Recoupment Status method. 
        /// </summary>
        [Required]
        public IEnumerable<ReportRecoupmentStatusDetailRecords> DetailRecords { get; set; }
    }
}
