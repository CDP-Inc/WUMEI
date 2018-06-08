using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Collection of Detail Records for the Report WIC Benefits Purged method.
    /// </summary>
    public class ReportWicBenefitsPurgedDetailRecords
    {
        /// <summary>
        /// A Unique number identifying a benefit issuance;
        /// Assigned by the WIC MIS system.
        /// </summary>
        /// <remarks>
        /// Original value from the benefits issued at the WIC MIS account ID level.
        /// </remarks>
        [Required, StringLength(20)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string BenefitIssuanceId { get; set; }

        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the 
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        /// <remarks>
        /// Required if benefits maintained at the Card number level.
        /// </remarks>
        [StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }

        /// <summary>
        /// First date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime BeginBenefitDate { get; set; }

        /// <summary>
        /// Last date on which benefits may be used expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime EndBenefitDate { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        [Required, StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Data element that is repeated for each Benefit issuance ID.
        /// </summary>
        [Required]
        public IEnumerable<FoodBenefitBalance> BenefitBalance { get; set; }
    }
}