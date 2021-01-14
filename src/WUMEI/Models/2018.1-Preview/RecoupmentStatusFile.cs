using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Data model for data in RecoupmentStatusReport.
    /// </summary>
    public class RecoupmentStatusFile
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        public BatchHeader BatchHeader { get; set; }

        /// <summary>
        /// Gets or sets a list containing the recoupment status records.
        /// </summary>
        [Required]
        public IEnumerable<RecoupmentStatusRecord> DetailRecords { get; set; }
    }
}
