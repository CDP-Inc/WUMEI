﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Request ACH Payment method.
    /// </summary>
    public class RequestAchPaymentBatch
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Gets or sets a collection of Detail Records for the Reqeust ACH Payment Batch method.
        /// </summary>
        [Required]
        public IEnumerable<RequestAchPaymentBatchDetailRecords> DetailRecords { get; set; }
    }
}