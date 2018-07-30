using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters returned for the Get Benefit Redemption History method.
    /// </summary>
    public class GetBenefitRedemptionHistoryResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Data element that is repeated for each purchase.
        /// </summary>
        public List<GetBenefitRedemptionHistoryResultBenefitRedemption> BenefitRedemptions { get; set; }
    }
}