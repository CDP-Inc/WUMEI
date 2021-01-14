using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <inheritdoc/>
    public class HouseholdMailingAddress : V2018.HouseholdMailingAddress
    {
        /// <inheritdoc/>
        [Required]
        [StringLength(60)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string AddressLine1 { get; set; }

        /// <inheritdoc/>
        [StringLength(60)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string AddressLine2 { get; set; }

        /// <inheritdoc/>
        [Required]
        [StringLength(25)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string AddressCity { get; set; }

        /// <inheritdoc/>
        [Required]
        [StringLength(2)]
        [RegularExpression(CustomRegex.Abc)]
        [StateType]
        public override string AddressState { get; set; }
    }
}
