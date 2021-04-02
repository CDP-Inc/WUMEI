using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters for the Update WIC Vendor Status method.
    /// </summary>
    public class UpdateWicVendorStatusBatch
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader Header { get; set; }

        /// <summary>
        /// Gets or sets a Collection of Detail Records for the Update WIC Vendor Status Batch method.
        /// </summary>
        [Required]
        public IEnumerable<UpdateWicVendorStatusBatchDetailRecords> Records { get; set; }
    }
}