﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WUMEI.Models.V2018;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Batch Confirmation File method.
    /// </summary>
    public class BatchConfirmationFile
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchConfirmationHeader Header { get; set; }

        /// <summary>
        /// Gets or sets the data elements for the Batch Confirmation File detail record.
        /// </summary>
        [Required]
        public IEnumerable<BatchConfirmationDetailRecord> Records { get; set; }
    }
}
