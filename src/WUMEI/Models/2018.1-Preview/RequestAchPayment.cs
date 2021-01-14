using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters required for the Request Ach Payment method.
    /// </summary>
    public class RequestAchPayment
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        /// <remarks>
        /// This function requires that banking data be provided. This does not mean that banking data needs to be
        /// stored by the sending system for all WIC Vendors.
        /// </remarks>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Add or Issue.
        /// </remarks>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets the number that identifies the financial institution to which a WIC Vendor is paid
        /// via ACH and conforms to the American Bankers Association standard.
        /// </summary>
        /// <remarks>
        /// Receiving institution bank identifier.
        /// </remarks>
        [Required]
        [StringLength(9, MinimumLength = 9)]
        [RegularExpression(CustomRegex.Num)]
        public string AbaRoutingTransitNumber { get; set; }

        /// <summary>
        /// Gets or sets the amount to be debited or credited to the WIC Vendor identified.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "99999999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal AchPaymentAmount { get; set; } = -1M;

        /// <summary>
        /// Gets or sets the number identifying the WIC Vendor's bank checking account.
        /// </summary>
        [Required]
        [StringLength(17, MinimumLength = 1)]
        [RegularExpression(CustomRegex.Num)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public virtual string BankName { get; set; }

        /// <summary>
        /// Gets or sets a code assigned by the acquirer to identify the WIC Vendor that defines the point of service.
        /// </summary>
        [StringLength(15)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string CardAcceptorIdentificationCode { get; set; }

        /// <summary>
        /// Gets or sets a  unique number assigned to a corporation to which WIC Vendors may be associated.
        /// </summary>
        /// <remarks>
        /// Required if payment at a hierarchy level other than the WIC Vendor.
        /// </remarks>
        [Range(typeof(long), "0", "999999999999")]
        public long? CorporationId { get; set; }

        /// <summary>
        /// Gets or sets a Date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Default is current date.
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets a  value indicating the position of the WIC Vendor location within the corporation hierarchy.
        /// Initializing to Byte.MaxValue to ensure it fails if the HierarchyCode isn't included in the json model
        /// </summary>
        [Required]
        [Range(typeof(byte), "0", "9")]
        public byte? HierarchyCode { get; set; }

        /// <summary>
        /// Gets or sets the original number assigned by the message initiator to uniquely
        /// identify a transaction in WIC redemption processing.
        /// </summary>
        /// <remarks>
        /// Required if this payment is related to a single, previous transaction.
        /// </remarks>
        [Range(typeof(int), "0", "999999")]
        public int? OriginalSystemsTraceAuditNumber { get; set; }

        /// <summary>
        /// Gets or sets a reason for an action.
        /// </summary>
        /// <remarks>
        /// Adjustment, Payment to warehouse, etc.
        /// </remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AchRequestPaymentReasonCodes)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the entity receiving the message or batch.
        /// </summary>
        /// <remarks>
        /// Used by sender as additional identifier for entity receiving the file.
        /// </remarks>
        [Range(typeof(long), "0", "99999999999")]
        public long? ReceivingInstitutionIdentificationCode { get; set; }

        /// <summary>
        /// Gets or sets a value assigned by the WIC Management Information System to identify the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required, StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }
    }
}
