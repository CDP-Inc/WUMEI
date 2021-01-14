using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Report Wic Benefit Month Data method.
    /// </summary>
    public class ReportWicBenefitMonthData : V2018.ReportWicBenefitMonthData
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new BatchHeader BatchHeader { get; set; }
    }
}
