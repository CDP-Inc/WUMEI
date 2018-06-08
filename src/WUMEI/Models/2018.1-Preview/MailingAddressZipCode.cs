using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class MailingAddressZipCode
    {
        /// <summary>
        /// A sub-element of Address ZIP code identifying the U.S. postal code associated with the address specified. 
        /// </summary>
        [Required, StringLength(5)]
        [RegularExpression(CustomRegex.Num)]
        public string ZipCodePrimary { get; set; }

        /// <summary>
        /// A sub-element of Address ZIP code, identifying the ZIP+4 U.S. postal codes for the address specified. 
        /// </summary>
        [StringLength(4)]
        [RegularExpression(CustomRegex.Num)]
        public string ZipCodeExtended { get; set; }
    }
}
