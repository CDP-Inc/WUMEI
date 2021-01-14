using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Collection of Data Records for the Update WIC Vendor Banking Information Batch method.
    /// </summary>
    public class UpdateWicVendorBankingInformationBatchDetailRecords
        : V2018.UpdateWicVendorBankingInformationBatchDetailRecords
    {
        /// <summary>
        /// Gets or sets the business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [JsonIgnore]
        public override string BankName { get; set; }
    }
}