using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Request Ach Payment method.
    /// </summary>
    public class RequestAchPayment : V2018.RequestAchPayment
    {
        #region Properties

        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the number identifying the WIC Vendor's bank checking account.
        /// </summary>
        [Range(1, 99999999999999999)]
        public new long BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets a bank name. This property is not used in the 2020.1 interface definition.
        /// </summary>
        [JsonIgnore]
        public override string BankName { get; set; }

        /// <summary>
        /// Gets or sets the original number assigned by the message initiator to uniquely
        /// identify a transaction in WIC redemption processing.
        /// </summary>
        /// <remarks>
        /// Required if this payment is related to a single, previous transaction.
        /// </remarks>
        [StringLength(6)]
        [RegularExpression(CustomRegex.Num)]
        public new string OriginalSystemsTraceAuditNumber { get; set; }

        #endregion Properties
    }
}
