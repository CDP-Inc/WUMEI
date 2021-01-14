using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters returned for the Add Update WIC Vendor method.
    /// </summary>
    public class AddUpdateWicVendorResult : V2018.AddUpdateWicVendorResult
    {
        #region Properties

        /// <summary>
        /// Gets or sets constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        #endregion Properties
    }
}
