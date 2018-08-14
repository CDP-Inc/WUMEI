using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Batch Confirmation File method.
    /// </summary>
    public class BatchConfirmationFile
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchConfirmationHeader BatchConfirmationHeader { get; set; }

        /// <summary>
        /// Data elements for the Batch Fonrimation File detail record.
        /// </summary>
        [Required]
        public IEnumerable<BatchConfirmationDetailRecord> DetailRecord { get; set; }
    }
}
