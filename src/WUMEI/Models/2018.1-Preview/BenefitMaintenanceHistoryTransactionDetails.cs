using System.Collections.Generic;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Represents the details of a benefit issuance.
    /// </summary>
    public class BenefitMaintenanceHistoryTransactionDetails
    {
        /// <summary>
        /// Gets or sets the benefit issuance ID.
        /// </summary>
        /// <remarks>
        /// This is the benefit issuance id range from 0 to 999,999,999,999.
        /// </remarks>
        public long? BenefitIssuanceId { get; set; }

        /// <summary>
        /// Gets or sets the sequence ID.
        /// </summary>
        public byte? BenefitIssuanceSequenceId { get; set; }

        /// <summary>
        /// Gets or sets the host date time for the transaction
        /// </summary>
        public string HostDateTime { get; set; }

        /// <summary>
        /// Gets or sets the benefit start date.
        /// </summary>
        public string BenefitBeginDate { get; set; }

        /// <summary>
        /// Gets or sets the benefit end date.
        /// </summary>
        public string BenefitEndDate { get; set; }

        /// <summary>
        /// Gets or sets the category details.
        /// </summary>
        public List<BenefitMaintenanceHistoryCategoryDetails> BenefitHistoryCategoryDetails { get; set; }
    }
}
