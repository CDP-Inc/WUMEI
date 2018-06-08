using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters for the Add Update Wic Vendor Hierarchy Information Batch method.
    /// </summary>
    public class AddUpdateWicVendorHierarchyInformationBatch
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Collection of Detail Records for the Add Update WIC Vendor Hierarchy Information Batch method.
        /// </summary>
        [Required]
        public IEnumerable<AddUpdateWicVendorHierarchyInformationBatchDetailRecords> DetailRecords { get; set; }
    }
}