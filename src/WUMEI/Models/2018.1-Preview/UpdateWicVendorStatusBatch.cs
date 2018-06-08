using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters for the Update WIC Vendor Status method. 
    /// </summary>
    public class UpdateWicVendorStatusBatch
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Collection of Detail Records for the Update WIC Vendor Status Batch method.
        /// </summary>
        [Required]
        public IEnumerable<UpdateWicVendorStatusBatchDetailRecords> DetailRecords { get; set; }
    }
}