using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    ///
    /// </summary>
    public class AddUpdateBenefitsBenefitBalance
    {
        /// <summary>
        /// A Unique number identifying a benefit issuance;
        /// Assigned by the WIC MIS system.
        /// </summary>
        /// <remarks>
        /// Assigned by the WIC MIS system at issuance;
        /// for updates/voids contains Benefit issuance ID assigned at issuance.
        /// </remarks>
        [Required]
        [Range(typeof(long), "0", "999999999999")]
        public long BenefitIssuanceId { get; set; }

        /// <summary>
        /// An integer number that increments with each Add or Update Benefits message sent using
        /// the same Benefit issuance id.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "99")]
        public int BenefitIssuanceSequenceNumber { get; set; }

        /// <summary>
        /// First date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BeginBenefitDate { get; set; }

        /// <summary>
        /// Last date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime EndBenefitDate { get; set; }

        /// <summary>
        /// Data element repeated for each food item in the purchase.
        /// </summary>
        [Required]
        public IEnumerable<FoodBenefitBalance> FoodBenefitBalance { get; set; }
    }
}
