using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Collection of Detail Records for the Report ACH Payments method.
    /// </summary>
    public class ReportAchPaymentsDetailRecords : V2018.ReportAchPaymentRecords
    {
        /// <summary>
        /// Gets or sets a the business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcSpecSpace)]
        [JsonIgnore]
        public override string BankName { get; set; }
    }
}