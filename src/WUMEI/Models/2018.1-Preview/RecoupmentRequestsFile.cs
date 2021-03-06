﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters required for the Report Recoupment Requests method.
    /// </summary>
    public class RecoupmentRequestsFile
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader Header { get; set; }

        /// <summary>
        /// Gets or sets a collection of Records for the Report Recoupment Requests method.
        /// </summary>
        [Required]
        public IEnumerable<RecoupmentRequestsRecords> Records { get; set; }
    }
}
