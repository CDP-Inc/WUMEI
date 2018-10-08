using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WUMEI.Models._2018._1_Preview;

namespace WUMEI.Models
{
    /// <summary>
    ///  A data object which represents a record in the WUMEI benefit purge file
    /// </summary>
    public class DailyBenefitExpungementRecord
    {
        /// <summary>
        /// Gets or sets an object identifying a record and carrying metadata about it.
        /// </summary>
        public BatchRecordHeader RecordHeader { get; set; }

        /// <summary>
        /// Gets or sets Benefit Issuance Id
        /// </summary>
        public long BenefitIssuanceId { get; set; }

        /// <summary>
        /// Gets or sets the card number.
        /// </summary>
        public ulong? CardNumber { get; set; }

        /// <summary>
        /// Gets or sets BenefitBeginDate
        /// </summary>
        public string BenefitBeginDate { get; set; }

        /// <summary>
        /// Gets or sets BenefitEffectiveDate
        /// </summary>
        public string BenefitEffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets BenefitEndDate
        /// </summary>
        public string BenefitEndDate { get; set; }

        /// <summary>
        /// Gets or sets the WIC MIS account ID.
        /// </summary>
        public string WICMisAccountId { get; set; }

        /// <summary>
        /// Gets or sets a list of Benefit Expungement Detail Records
        /// </summary>
        public List<DailyBenefitExpungementDetailRecord> ExpungementDetails { get; set; }
            = new List<DailyBenefitExpungementDetailRecord>();
    }
}