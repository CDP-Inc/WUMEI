using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Collection of Detail Records for the Reqeust ACH Payment Batch method.
    /// </summary>
    public class RequestAchPaymentBatchDetailRecords : V2018.RequestAchPaymentBatchDetailRecords
    {
        /// <summary>
        /// Gets or sets the business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcSpecSpace)]
        [JsonIgnore]
        public override string BankName { get; set; }
    }
}