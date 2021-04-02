using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters for the Update WIC Vendor Banking Information method. 
    /// </summary>
    public class UpdateWicVendorBankingInformationBatch
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader Header { get; set; }

        /// <summary>
        /// Gets or sets a collection of Data Records for the Update WIC Vendor Banking Information Batch method.
        /// </summary>
        [Required]
        public IEnumerable<UpdateWicVendorBankingInformationBatchDetailRecords> Records { get; set; }
    }
}