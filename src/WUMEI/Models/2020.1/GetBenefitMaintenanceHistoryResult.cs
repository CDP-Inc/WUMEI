using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Objects of this class will hold the results of GetBenefitMaintenanceResut method
    /// </summary>
    public class GetBenefitMaintenanceHistoryResult : V2018.GetBenefitMaintenanceHistoryResult
    {
        #region Properties

        /// <summary>
        /// Gets or sets the constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        #endregion Properties
    }
}
