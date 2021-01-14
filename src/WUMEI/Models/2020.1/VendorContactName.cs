using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains fields for vendor contact names.
    /// </summary>
    public class VendorContactName : V2018.VendorContactName
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
