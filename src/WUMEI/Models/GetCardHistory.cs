using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Get Card History method.
    /// </summary>
    public class GetCardHistory
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
        /// Required if WIC MIS account ID is not present.
        /// </remarks>
        [StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Beginning of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// If not present, defaults to all dates.
        /// </remarks>
        public DateTime BeginRequestDate { get; set; }

        /// <summary>
        /// End of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// If not present, defaults to all dates.
        /// </remarks>
        public DateTime EndRequestDate { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// Cardholder type (Primary, Secondary, Proxy).
        /// </remarks>
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        /// <remarks>
        /// Required if Card number is not present.
        /// </remarks>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }
    }
}