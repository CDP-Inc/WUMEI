using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Get Benefit Redemption History method.
    /// </summary>
    public class GetBenefitRedemptionHistory
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
        [StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }

        /// <summary>
        /// End of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndRequestDate { get; set; }

        /// <summary>
        /// Beginning of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginRequestDate { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        /// <remarks>
        /// Required if Card number not present.
        /// </remarks>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// Required if request is for specific transaction types (Purchase, Void, Expunged/expired, etc.)
        /// </remarks>
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Value assigned by the WIC Management Information System to idenfity the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        /// <remarks>
        /// If provided, only transactions for the specified WIC vendor are retrieved.
        /// </remarks>
        [StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }
    }
}