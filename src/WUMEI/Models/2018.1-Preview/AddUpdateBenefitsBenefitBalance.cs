using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains the benefit balance for the Add Update Benefits method.
    /// </summary>
    public class AddUpdateBenefitsBenefitBalance
    {
        /// <summary>
        /// Gets or sets a Unique number identifying a benefit issuance;
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
        /// Gets or sets an integer number that increments with each Add or Update Benefits message sent using
        /// the same Benefit issuance id.
        /// </summary>
        [Required]
        [Range(typeof(int), "1", "99")]
        public int BenefitIssuanceSequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the first date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [DateTimeValidation]
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets the last date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [DateTimeValidation]
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets the data element repeated for each food item in the purchase.
        /// </summary>
        [Required]
        public IEnumerable<FoodBenefitBalance> FoodBenefitBalance { get; set; }
    }
}
