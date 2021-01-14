using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// The input model form the GetBenefitMaintenanceHistory function
    /// </summary>
    public class GetBenefitMaintenanceHistory : V2018.GetBenefitMaintenanceHistory
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
