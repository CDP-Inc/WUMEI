using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Add Update Benefits method.
    /// </summary>
    public class AddUpdateBenefits
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Issue, or void.
        /// </remarks>
        [Required]
        [Range(typeof(short), "0", "999")]
        public short ActionCode { get; set; }

        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Range(typeof(ulong), "0", "9999999999999999999")]
        public ulong? CardNumber { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        [Required, StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Data element that is repeated for each Benefit issuance ID.
        /// </summary>
        [Required]
        public IEnumerable<AddUpdateBenefitsBenefitBalance> BenefitBalance { get; set; }
    }
}