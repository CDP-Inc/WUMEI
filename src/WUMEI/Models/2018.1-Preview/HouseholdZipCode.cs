using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// An object containing the ZIP code for a mailing address
    /// </summary>
    public class HouseholdZipCode
    {
        /// <summary>
        /// Gets or sets a sub-element of Address ZIP code identifying the U.S. postal code associated with
        /// the address specified.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(5)]
        [RegularExpression(CustomRegex.Num)]
        public string ZipCodePrimary { get; set; }

        /// <summary>
        /// Gets or sets a sub-element of Address ZIP code, identifying the ZIP+4 U.S. postal codes for
        /// the address specified.
        /// </summary>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.Num)]
        public string ZipCodeExtended { get; set; }
    }
}
