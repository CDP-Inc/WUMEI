using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters returned for the Get Benefit Redemption History method.
    /// </summary>
    public class GetBenefitRedemptionHistoryResult
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a data element that is repeated for each purchase.
        /// </summary>
        public List<GetBenefitRedemptionHistoryResultBenefitRedemption> BenefitRedemptions { get; set; }
    }
}