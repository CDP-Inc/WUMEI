using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters for the Add Update Wic Vendor Hierarchy Information Batch method.
    /// </summary>
    public class AddUpdateWicVendorHierarchyInformationBatch
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Gets or sets a collection of Detail Records for the Add Update WIC Vendor Hierarchy Information Batch method.
        /// </summary>
        [Required]
        public IEnumerable<AddUpdateWicVendorHierarchyInformationBatchDetailRecords> DetailRecords { get; set; }
    }
}