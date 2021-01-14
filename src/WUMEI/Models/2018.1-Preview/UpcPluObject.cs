using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Represents a UPC or PLU
    /// </summary>
    public class UpcPluObject
    {
        /// <summary>
        /// Gets or sets a code which indicates whether the data is a UPC (value = 0) or a
        /// PLU (value = 1)
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "1")]
        public byte? UpcPluIndicator { get; set; }

        /// <summary>
        /// Gets or sets the UPC or PLU code identifying the product.
        /// </summary>
        [Required]
        [Range(typeof(long), "0", "999999999999999")]
        public long? UpcPluCode { get; set; }

        /// <summary>
        /// Gets or sets a calculated value derived using the UPC-A check digit algorithm from GS1.
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "9")]
        public byte? UpcPluCheckDigit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the number of significant digits in the UPC or PLU plus
        /// 1 for the check digit.
        /// </summary>
        [Required]
        [Range(typeof(byte), "2", "16")]
        public byte? UpcPluDataLength { get; set; }
    }
}
