using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// The input model for the GetCardHistory function.
    /// </summary>
    public class GetCardHistory
    {
        /// <summary>
        /// Gets or sets data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the WIC Card number to obtain transaction history for.
        /// </summary>
        [Range(typeof(ulong), "1000000000000000", "9999999999999999999")]
        public ulong? CardNumber { get; set; }

        /// <summary>
        /// Gets or sets beginning date for transactions to be returned for this function
        /// expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginRequestDate { get; set; }

        /// <summary>
        /// Gets or sets ending date for transactions to be returned for this function
        /// expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndRequestDate { get; set; }

        /// <summary>
        /// Gets or sets code indicating the kind of entity being reported upon in the function.
        /// </summary>
        /// <remarks>
        /// May only be used with an optional data element to request a specific cardholder type
        /// (Primary, Secondary, Proxy).
        /// </remarks>
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets WIC MIS account being reported on by this function.
        /// </summary>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }
    }
}