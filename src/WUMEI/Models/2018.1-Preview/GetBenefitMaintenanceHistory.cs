using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// The Get Benefit Maintenance History function is a required function that uses a message based system
    ///interface to retrieve benefit maintenance transaction data for a particular EBA.
    /// </summary>
    public class GetBenefitMaintenanceHistory
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        /// <remarks>
        /// Required if WIC MIS account ID not present.
        /// </remarks>
        [Range(typeof(ulong), "0", "9999999999999999999")]
        public ulong? CardNumber { get; set; }

        /// <summary>
        /// Beginning of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginRequestDate { get; set; }

        /// <summary>
        /// End of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndRequestDate { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// Used to request specific types of maintenance (Add, Void, Purged).
        /// </remarks>
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        /// <remarks>
        /// Required if Card number not present.
        /// </remarks>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }
    }
}