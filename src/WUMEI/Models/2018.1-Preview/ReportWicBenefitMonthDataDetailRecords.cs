using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Collection of Detail Records for the Report WIC Benefit Month Data method.
    /// </summary>
    public class ReportWicBenefitMonthDataDetailRecords
    {
        /// <summary>
        /// Gets or sets an object identifying a record and carrying metadata about it.
        /// </summary>
        public BatchRecordHeader RecordHeader { get; set; }

        /// <summary>
        /// Gets or sets a value that identifies the month and year from the Effective date in the ACH payment
        /// of the benefits being reported.
        /// </summary>
        /// <remarks>
        /// MMCCYY format.
        /// </remarks>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string AchPaymentMonth { get; set; }

        /// <summary>
        /// Gets or sets total of funds to be transferred between the parties identified.
        /// </summary>
        [Required, StringLength(13)]
        [RegularExpression(CustomRegex.AbcNumSpec)]
        public string SettledAmounts { get; set; }

        /// <summary>
        /// Gets or sets a period by the WIC State Agency in which benefits are in effect; may be a
        /// calendar month or a rolling number of days.
        /// </summary>
        /// <remarks>
        /// MMCCYY.
        /// </remarks>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string BenefitMonth { get; set; }

        /// <summary>
        /// Gets or sets first day that benefits for the period are available for purchase.
        /// </summary>
        /// <remarks>
        /// CCYYMMDD.
        /// </remarks>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string FirstDateToSpend { get; set; }

        /// <summary>
        /// Gets or sets last day that benefits for the period are available for purchase.
        /// </summary>
        /// <remarks>
        /// CCYYMMDD.
        /// </remarks>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string LastDateToSpend { get; set; }

        /// <summary>
        /// Gets or sets a value assigned by the WIC MIS to identify an account for a WIC participant,
        /// economic unit or household.
        /// </summary>
        /// <remarks>
        /// Required if Card number not present.
        /// </remarks>
        [Required, StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element containing elements that are repeated for each Category
        /// and Subcategory in the household account during the Benefit month specified.
        /// </summary>
        public IEnumerable<BenefitQuantityInformation> BenefitQuantityInformation { get; set; }
    }
}