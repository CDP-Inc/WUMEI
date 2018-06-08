using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters for the Update WIC Vendor Banking Information method. 
    /// </summary>
    public class UpdateWicVendorBankingInformationBatch
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Collection of Data Records for the Update WIC Vendor Banking Information Batch method.
        /// </summary>
        [Required]
        public IEnumerable<UpdateWicVendorBankingInformationBatchDetailRecords> DetailRecords { get; set; }
    }
}