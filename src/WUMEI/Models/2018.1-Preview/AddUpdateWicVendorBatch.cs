using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all paremeters required for the Add Update WIC Vendor Batch method.
    /// </summary>
    public class AddUpdateWicVendorBatch
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Collection of Detail Records for the Add Update Wic Vendor Batch method.
        /// </summary>
        [Required]
        public IEnumerable<AddUpdateWicVendorBatchDetailRecords> DetailRecords { get; set; }
    }
}