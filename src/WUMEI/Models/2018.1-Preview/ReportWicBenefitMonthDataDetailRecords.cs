using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Collection of Detail Records for the Report WIC Benefit Month Data method.
    /// </summary>
    public class ReportWicBenefitMonthDataDetailRecords
    {
        /// <summary>
        /// Identifies the month and year from the Effective date in the ACH payment of the benefits being reported.
        /// </summary>
        /// <remarks>
        /// MMCCYY format.
        /// </remarks>
        [Required]
        public DateTime AchPaymentMonth { get; set; }

        /// <summary>
        /// Total of funds to be transferred between the parties identified.
        /// </summary>
        [Required, StringLength(13)]
        [RegularExpression(CustomRegex.AbcNumSpec)]
        public string SettledAmounts { get; set; }

        /// <summary>
        /// A period by the WIC State Agency in which benefits are in effect; may be a calendar month or a rolling
        /// number of days.
        /// </summary>
        /// <remarks>
        /// MMCCYY.
        /// </remarks>
        [Required]
        public DateTime BenefitMonth { get; set; }

        /// <summary>
        /// First day that benefits for the period are available for purchase.
        /// </summary>
        /// <remarks>
        /// CCYYMMDD.
        /// </remarks>
        [Required]
        public DateTime FirstDateToSpend { get; set; }

        /// <summary>
        /// Last day that benefits for the period are available for purchase.
        /// </summary>
        /// <remarks>
        /// CCYYMMDD.
        /// </remarks>
        [Required]
        public DateTime LastDateToSpend { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        /// <remarks>
        /// Required if Card number not present.
        /// </remarks>
        [Required, StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Constructed data element containing elements that are repeated for each Category and Subcategory in the
        /// household account during the Benefit month specified.
        /// </summary>
        public IEnumerable<BenefitQuantityInformation> BenefitQuantityInformation { get; set; }
    }
}