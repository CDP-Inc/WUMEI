using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// The Get Benefit Balance function is a required function that uses a message based system interface to
    /// retrieve benefit information for a particular EBA
    /// </summary>
    public class GetBenefitBalance
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A Unique number identifying a benefit issuance;
        /// Assigned by the WIC MIS system.
        /// </summary>
        /// <remarks>
        /// Required if specific Benefit issuance ID requested.
        /// </remarks>
        [StringLength(20)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string BenefitIssuanceId { get; set; }

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
        /// Beginning of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginRequestDate { get; set; }

        /// <summary>
        /// End of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndRequestDate { get; set; }

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