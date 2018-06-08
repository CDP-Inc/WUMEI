using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters returned for the Get Benefit Balance method.
    /// </summary>
    public class GetBenefitBalanceResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        /// <remarks>
        /// Required if not sent in request.
        /// </remarks>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Data object containing elements that are repeated for each WIC MIS account ID.
        /// </summary>
        [Required]
        public IEnumerable<GetBenefitBalanceResultBenefitBalance> BenefitBalance { get; set; }
    }
}