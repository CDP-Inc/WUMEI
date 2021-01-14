using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// The input model for the GetCardHistory function
    /// </summary>
    public class GetCardHistory : V2018.GetCardHistory
    {
        #region Properties

        /// <summary>
        /// Gets or sets data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        #endregion Properties
    }
}
