using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Mailing Address object to be used when Mailing Address is required.
    /// </summary>
    public class MailingAddress
    {
        /// <summary>
        /// Gets or sets a sub-element of address data elements identifying the first line of the address specified.
        /// </summary>
        [Required]
        [StringLength(30)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets a sub-element of address data elements identifying the second line, if present,
        /// of the address specified.
        /// </summary>
        [StringLength(30)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets a sub-element of address data elements identifying the city name of the address specified.
        /// </summary>
        [Required]
        [StringLength(25)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Gets or sets a sub-element of address data elements; conforms to the U.S. Post Office state
        /// and territory abbreviations.
        /// </summary>
        [Required]
        [StringLength(2)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string AddressState { get; set; }

        /// <summary>
        /// Gets or sets a sub-element of address data elements and a constructed data element including
        /// the Address ZIP code, primary and the Address ZIP code, extended for the address specified.
        /// </summary>
        [Required]
        public MailingAddressZipCode AddressZipCode { get; set; }
    }
}