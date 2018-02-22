using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Collection of Detail Records for the Report Recoupment Requests method.
    /// </summary>
    public class ReportRecoupmentRequestsDetailRecords
    {
        /// <summary>
        /// The amount to debit or credit from the running total of recoupment according to the action in Type code.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "9999999999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal RecoupmentAmount { get; set; }

        /// <summary>
        /// The first of the month used to calculate the new Amount, recoupment.
        /// </summary>
        /// <remarks>
        /// CCYYMMDD.
        /// </remarks>
        [Required]
        public DateTime RecoupmentProcessingMonth { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// Indicates transaction type (Reversal, Void).
        /// </remarks>
        [Required, StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }
    }
}