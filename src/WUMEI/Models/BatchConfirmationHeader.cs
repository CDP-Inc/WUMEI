using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models
{
    /// <summary>
    /// The following data elements shall be returned in each batch system interface at the file level
    /// and at the record level.
    /// </summary>
    public class BatchConfirmationHeader : BatchHeader
    {
        /// <summary>
        /// The original value that identified the function performed.
        /// </summary>
        [Required]
        [Range(typeof(short), "0", "9999")]
        public short OriginalMessageOrFileTypeCode { get; set; }

        /// <summary>
        /// The number lines in a file that were rejected where each line is terminated with a "CR" or "LF" character.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "9999999")]
        public int RejectedLineCount { get; set; }
    }
}
