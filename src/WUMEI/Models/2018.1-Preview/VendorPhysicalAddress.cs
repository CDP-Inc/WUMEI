using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Represents a household's mailing address.
    /// </summary>
    public class VendorPhysicalAddress
    {
        #region Properties

        /// <summary>
        /// Gets or sets the sub-element of address data elements identifying the first line of the address specified.
        /// </summary>
        [Required]
        [StringLength(60)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public virtual string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the sub-element of address data elements identifying the second line, if present,
        /// of the address specified.
        /// </summary>
        [StringLength(60)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public virtual string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the sub-element of address data elements identifying the city name of the address specified.
        /// </summary>
        [Required]
        [StringLength(25)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public virtual string AddressCity { get; set; }

        /// <summary>
        /// Gets or sets the sub-element of address data elements; conforms to the U.S. Post Office state and
        /// territory abbreviations.
        /// </summary>
        [Required]
        [StringLength(2)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        [StateType]
        public virtual string AddressState { get; set; }

        /// <summary>
        /// Gets or sets the sub-element of address data elements and a constructed data element including
        /// the Address ZIP code, primary and the Address ZIP code, extended for the address specified.
        /// </summary>
        [Required]
        public VendorPhysicalZipCode AddressZipCode { get; set; }

        #endregion
    }
}
