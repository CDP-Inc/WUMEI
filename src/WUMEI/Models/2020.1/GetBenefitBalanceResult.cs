using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters returned for the Get Benefit Balance method.
    /// </summary>
    public class GetBenefitBalanceResult : V2018.GetBenefitBalanceResult
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
