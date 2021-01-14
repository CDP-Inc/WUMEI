using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains fields for head of household contact name.
    /// </summary>
    public class HouseholdContactName : V2018.HouseholdContactName
    {
        /// <inheritdoc/>
        [Required]
        [StringLength(50)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string FirstName { get; set; }

        /// <inheritdoc/>
        [StringLength(1)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string MiddleInitial { get; set; }

        /// <inheritdoc/>
        [Required]
        [StringLength(50)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string LastName { get; set; }

        /// <inheritdoc/>
        [StringLength(6)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string NameSuffix { get; set; }
    }
}
