using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters for the Update WIC Vendor Banking Information method.
    /// </summary>
    public class UpdateWicVendorBankingInformation : V2018.UpdateWicVendorBankingInformation
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [JsonIgnore]
        public override string BankName { get; set; }
    }
}