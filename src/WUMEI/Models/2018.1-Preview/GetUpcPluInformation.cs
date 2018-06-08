using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Get UPC/PLU Information method.
    /// </summary>
    public class GetUpcPluInformation
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Information identifying the UPC or PLU assigned to a food item;
        /// see Technical Implementation Guide for formatting.
        /// </summary>
        /// <remarks>
        /// Contains the UPC or PLU being requested.
        /// Contains UPC/PLU indicator, UPC/PLU and UPC/PLU check digit
        /// </remarks>
        [Required, StringLength(17)]
        [RegularExpression(CustomRegex.Num)]
        public string UpcPluData { get; set; }

        /// <summary>
        /// Indicate the number of significant digits in the UPC or PLU
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "15")]
        public byte UpcPluDataLength { get; set; }
    }
}