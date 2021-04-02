using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Report Recoupment Requests method.
    /// </summary>
    public class ReportRecoupmentRequests : V2018.RecoupmentRequestsFile
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new BatchHeader Header { get; set; }
    }
}
