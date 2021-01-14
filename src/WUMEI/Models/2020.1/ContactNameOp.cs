using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains fields for Contact Names when they are optional.
    /// </summary>
    public class ContactNameOp : V2018.ContactNameOp
    {
        /// <inheritdoc/>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string FirstName { get; set; }

        /// <inheritdoc/>
        [StringLength(1)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string MiddleInitial { get; set; }

        /// <inheritdoc/>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string LastName { get; set; }

        /// <inheritdoc/>
        [StringLength(6)]
        [RegularExpression(CustomRegex.AnprPattern)]
        public override string NameSuffix { get; set; }
    }
}
