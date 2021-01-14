using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Objects of this class will hold the results of GetCardHistory method
    /// </summary>
    public class GetCardHistoryResult : V2018.GetCardHistoryResult
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
