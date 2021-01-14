using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Objects of this class will hold the results of GetBenefitMaintenanceResut method
    /// </summary>
    public class GetBenefitMaintenanceHistoryResult
    {
        /// <summary>
        /// Gets or sets the constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the list of benefit maintenance history transactions.
        /// </summary>
        public List<BenefitMaintenanceHistoryTransaction> BenefitHistoryTransactions { get; set; }
    }
}
