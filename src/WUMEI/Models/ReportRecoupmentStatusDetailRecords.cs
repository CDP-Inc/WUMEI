using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Collection of Detail Records for the Report Recoupment Status method.
    /// </summary>
    public class ReportRecoupmentStatusDetailRecords
    {
        /// <summary>
        /// The beginning balance of recoupment on a given activity day.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal BeginningRecoupmentAmount { get; set; }

        /// <summary>
        /// The ending balance of recoupment on a given activity day.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal EndingRecoupmentAmount { get; set; }

        /// <summary>
        /// The amount of new recoupment amounts received on a given activity day.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal NewRecoupmentAmount { get; set; }

        /// <summary>
        /// The amount of credit adjustments to recoupment received on a given activity day.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal RecoupmentCreditAdjustmentAmount { get; set; }

        /// <summary>
        /// The amount of debit adjustments to recoupment received on a given activity day.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal RecoupmentDebitAdjustmentAmount { get; set; }

        /// <summary>
        /// The amount of recoupment recovered through redemptions on a given activity day.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal RecoupmentRecoveredAmount { get; set; }

        /// <summary>
        /// The amount of recoupment added back through purchase reversals/voids on a given activity day.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal RecoupmentReversedAmount { get; set; }

        /// <summary>
        /// The discrepancy between a snapshot balance of recoupments and the amount calculated from the
        /// WIC Direct audit trail.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal RecoupmentVarianceAmount { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        /// <remarks>
        /// Vendor status.
        /// </remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// The year, month and day of recoupment activity being summarized.
        /// </summary>
        /// <remarks>
        /// CCYYMMDD.
        /// </remarks>
        [Required]
        public DateTime RecoupmentActivityDate { get; set; }

        /// <summary>
        /// Value assigned by the WIC Management Information System to idenfity the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required, StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }
    }
}