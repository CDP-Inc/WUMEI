using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Collection of Detail Records for the Report Daily Outstanding Liability method.
    /// </summary>
    public class ReportDailyOutstandingLiabilityDetailRecords : V2018.ReportDailyOutstandingLiabilityDetailRecords
    {
        /// <summary>
        /// Gets or sets date and time the originator of the function sends the message or batch expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// File cutoff date and time, in GMT.
        /// </remarks>
        [JsonIgnore]
        public override DateTime TransmissionDateTime { get; set; }

        /// <summary>
        /// Gets or sets date and time the originator of the function sends the message or batch expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// File cutoff date and time, in GMT.
        /// </remarks>
        [Required]
        public DateTime CutoffDateTime { get; set; }

    }
}