using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Collection of Detail Records for the Report Daily Outstanding Liability method.
    /// </summary>
    public class ReportDailyOutstandingLiabilityDetailRecords
    {
        /// <summary>
        /// Date and time the originator of the function sends the message or batch expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// File cutoff date and time, in GMT.
        /// </remarks>
        [Required]
        public DateTime TransmissionDateTime { get; set; }

        /// <summary>
        /// Constructed data element containing elements that are repeated for each current and future
        /// Sub-Category code within each Category code.
        /// </summary>
        [Required]
        public IEnumerable<OustandingLiabilities> OutStandingLiabilities { get; set; }
    }
}