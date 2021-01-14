using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Collection of Detail Records for the Report Recoupment Requests method.
    /// </summary>
    public class RecoupmentRequestsRecords
    {
        /// <summary>
        /// Gets or sets an object identifying a record and carrying metadata about it.
        /// </summary>
        public BatchRecordHeader RecordHeader { get; set; }

        /// <summary>
        /// Gets or sets the amount to debit or credit from the running total of recoupment according to
        /// the action in <see cref="TypeCode"/>.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "9999999999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal RecoupmentAmount { get; set; }

        /// <summary>
        /// Gets or sets the first of the month used to calculate the new <see cref="RecoupmentAmount"/>.
        /// </summary>
        /// <remarks>
        /// CCYYMMDD.
        /// </remarks>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string RecoupmentProcessingMonth { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// Indicates transaction type (Reversal, Void).
        /// </remarks>
        [Required]
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }



        /// <summary>
        /// Gets or sets a value assigned by the WIC Management Information System to identify the WIC Vendor
        /// </summary>
        /// <remarks>
        /// Indicates transaction type (Reversal, Void).
        /// </remarks>
        [Required]
        [StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }
    }
}