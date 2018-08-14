using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models
{
    /// <summary>
    /// Data elements which are present at the record level for all batch file records.
    /// </summary>
    public class BatchRecordHeader
    {
        /// <summary>
        /// Gets or sets a sequential number assigned to each record within a batch by the batch sender.
        /// </summary>
        public int RecordSequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets a string used to identify user in the WIC EBT System. Used in conjunction with the
        /// WIC EBT System ID to uniquely identify a user.
        /// </summary>
        /// <remarks>
        /// Required if record was created as the result of an action by a WIC EBT system user.
        /// </remarks>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets a value identifying the workstation initiating the function.
        /// </summary>
        /// <remarks>
        /// Required if record was created as the result of an action by a user.
        /// </remarks>
        public string WorkstationId { get; set; }
    }
}
