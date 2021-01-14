using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Represents a batch confirmation file header.
    /// </summary>
    public class BatchConfirmationHeader : BatchHeader
    {
        /// <summary>
        /// Gets or sets the original value that identified the function performed.
        /// </summary>
        [Required]
        [Range(typeof(short), "0", "9999")]
        public short OriginalMessageOrFileTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the number lines in a file that were rejected where each line is terminated with a "CR" or
        /// "LF" character.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "9999999")]
        public int RejectedLineCount { get; set; }
    }
}
