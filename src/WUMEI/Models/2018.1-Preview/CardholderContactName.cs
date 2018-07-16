using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains fields for Contact Names when they are required.
    /// </summary>
    public class CardholderContactName
    {
        /// <summary>
        /// Sub-element of name data elements identifying the first name of the person specified.
        /// </summary>
        [Required, StringLength(20)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string FirstName { get; set; }

        /// <summary>
        /// Sub-element of name data elements identifying the middle initial of the person specified.
        /// </summary>
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Sub-element of name data elements identifying the last name of the person specified.
        /// </summary>
        [Required, StringLength(20)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string LastName { get; set; }

        /// <summary>
        /// Sub-element of name data elements identifying the suffix of the person specified.
        /// </summary>
        [StringLength(6)]
        [RegularExpression(CustomRegex.AbcNumSpecSpaceNameAndAddress)]
        public string NameSuffix { get; set; }
    }
}