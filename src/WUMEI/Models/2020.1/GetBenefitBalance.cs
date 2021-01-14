using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// The Get Benefit Balance function is a required function that uses a message based system interface to retrieve
    /// benefit information for a particular EBA
    /// </summary>
    public class GetBenefitBalance : V2018.GetBenefitBalance
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
