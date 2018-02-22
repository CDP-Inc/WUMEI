using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Mailing Address object to be used when Mailing Address is optional.
    /// </summary>
    public class MailingAddressOp
    {
        /// <summary>
        /// Sub-element of address data elements identifying the first line of the address specified. 
        /// </summary>
        [StringLength(30)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Sub-element of address data elements identifying the second line, if present, of the address specified. 
        /// </summary>
        [StringLength(30)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Sub-element of address data elements identifying the city name of the address specified.
        /// </summary>
        [StringLength(25)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Sub-element of address data elements; conforms to the U.S. Post Office state and territory abbreviations. 
        /// </summary>
        [StringLength(2)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string AddressState { get; set; }

        /// <summary>
        /// Sub-element of address data elements and a constructed data element including the Address ZIP code, 
        /// primary and the Address ZIP code, extended for the address specified.
        /// </summary>
        [RegularExpression(CustomRegex.Num)]
        public MailingAddressZipCode AddressZipCode { get; set; }
    }
}
