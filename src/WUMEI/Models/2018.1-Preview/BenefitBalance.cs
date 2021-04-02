using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Repeated data elements for each WIC MIS account ID and/or Card number.
    /// </summary>
    public class BenefitBalance
    {
        /// <summary>
        /// Gets or sets a Unique number identifying a benefit issuance;
        /// Assigned by the WIC MIS system.
        /// </summary>
        [Required, StringLength(20)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string BenefitIssuanceId { get; set; }

        /// <summary>
        /// Gets or sets an integer number that increments with each Add or Update Benefits message sent using
        /// the same Benefit issuance id.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "99")]
        public int BenefitIssuanceSeqNumber { get; set; }

        /// <summary>
        /// Gets or sets the date/time when a transaction occurred based on date/time of EBT Card Issuer Processor
        /// system expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime HostDateAndTime { get; set; }

        /// <summary>
        /// Gets or sets the first date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BenefitBeginDate { get; set; }

        /// <summary>
        /// Gets or sets the last date on which benefits may be used expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BenefitEndDate { get; set; }

        /// <summary>
        /// Gets or sets the data element containing details of the food benefit balance of
        /// each food item prescribed to the household.
        /// </summary>
        [Required]
        public IEnumerable<BenefitCategoryDetails> BenefitCategoryDetails { get; set; }
    }
}
