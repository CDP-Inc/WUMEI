using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Get Benefit Redemption History method.
    /// </summary>
    public class GetBenefitRedemptionHistory : V2018.GetBenefitRedemptionHistory
    {
        #region Properties

        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        #endregion Properties
    }
}
