using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Represents a UPC or PLU
    /// </summary>
    public class UpcPluObject
    {
        /// <summary>
        /// Gets or sets a value indicating whether or not the code represents a PLU or UPC
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "1")]
        public byte UpcPluIndicator { get; set; }

        /// <summary>
        /// Gets or sets the UPC or PLU code.
        /// </summary>
        [Required]
        [Range(typeof(long), "0", "999999999999999")]
        public long UpcPluCode { get; set; }

        /// <summary>
        /// Gets or sets the UPC check digit.
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "9")]
        public byte UpcPluCheckDigit { get; set; }

        /// <summary>
        /// Gets or sets the UPC of PLU data length.
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "99")]
        public byte UpcPluDataLength { get; set; }
    }
}
