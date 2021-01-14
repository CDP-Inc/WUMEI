using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// The Get Benefit Balance function is a required function that uses a message based system interface to
    /// retrieve benefit information for a particular EBA
    /// </summary>
    public class GetBenefitBalance
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a Unique number identifying a benefit issuance;
        /// Assigned by the WIC MIS system.
        /// </summary>
        /// <remarks>
        /// Required if specific Benefit issuance ID requested.
        /// </remarks>
        [Range(typeof(long), "0", "999999999999")]
        public long? BenefitIssuanceId { get; set; }

        /// <summary>
        /// Gets or sets a series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        /// <remarks>
        /// Required if WIC MIS account ID not present.
        /// </remarks>
        [Range(typeof(ulong), "1000000000000000", "9999999999999999999")]
        public ulong? CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the beginning of period being referenced for this function expressed in GMT in accordance
        /// with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginRequestDate { get; set; }

        /// <summary>
        /// Gets or sets the end of period being referenced for this function expressed in GMT in accordance
        /// with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndRequestDate { get; set; }

        /// <summary>
        /// Gets or sets the value assigned by the WIC MIS to identify an account for a WIC participant,
        /// economic unit or household.
        /// </summary>
        /// <remarks>
        /// Required if Card number not present.
        /// </remarks>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }
    }
}
