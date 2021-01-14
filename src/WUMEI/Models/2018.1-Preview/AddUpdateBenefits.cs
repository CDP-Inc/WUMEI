using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters required for the Add Update Benefits method.
    /// </summary>
    public class AddUpdateBenefits
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Issue, or void.
        /// </remarks>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets a series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Range(typeof(ulong), "1000000000000000", "9999999999999999999")]
        public ulong? CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the value assigned by the WIC MIS to identify an account for a WIC participant,
        /// economic unit or household.
        /// </summary>
        [Required]
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Gets or sets the reason for an action.
        /// </summary>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the data element that is repeated for each Benefit issuance ID.
        /// </summary>
        [Required]
        [NumItems(Min = 1)]
        public IEnumerable<AddUpdateBenefitsBenefitBalance> BenefitBalance { get; set; }
    }
}
