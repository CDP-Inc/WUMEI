using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models
{
    /// <summary>
    /// Data model for data in RecoupmentStatusReport.
    /// </summary>
    public class RecoupmentStatusFile
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Gets or sets a list containing the recoupment status records.
        /// </summary>
        [Required]
        public IEnumerable<RecoupmentStatusRecord> DetailRecords { get; set; }
    }
}
