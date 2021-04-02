using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Data model for data in RecoupmentStatusReport.
    /// </summary>
    public class RecoupmentStatusFile : V2018.RecoupmentStatusFile
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        public new BatchHeader Header { get; set; }
    }
}
