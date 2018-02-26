using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Data elements for the Batch Fonrimation File detail record.
    /// </summary>
    public class BatchConfirmationFileDetailRecord
    {
        /// <summary>
        /// A value returned in a message based system interface to explicitly indicate the information 
        /// sent was received and the action taken.
        /// </summary>
        /// <remarks>Indicates that a message was received and the result of processing the message.</remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.Num)]
        public string FunctionReturnCode { get; set; }

        /// <summary>
        /// Text description associated with Function return code. 
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string FunctionReturnText { get; set; }

        /// <summary>
        /// The original number of a line in a file where each line is terminated with a "CR" and/or "LF" character.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "9999999")]
        public int OriginalLineNumber { get; set; }

        /// <summary>
        /// A sequential number assigned to each record within a batch by the batch sender.
        /// </summary>
        /// <remarks>
        /// The record sequence number of the record from the original file with an error.
        /// </remarks>
        [Required]
        [Range(typeof(int), "0", "999999")]
        public int RecordSequenceNumber { get; set; }
    }
}