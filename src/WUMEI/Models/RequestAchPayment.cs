using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Request ACH Payment method.
    /// </summary>
    public class RequestAchPayment
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        /// <remarks>
        /// This function requires that banking data be provided. This does not mean that banking data needs to be 
        /// stored by the sending system for all WIC Vendors. 
        /// </remarks>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Add or Issue.
        /// </remarks>
        [Required, StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// The number that identifies the financial institution to which a WIC Vendor is paid
        /// via ACH and conforms to the American Bankers Association standard.
        /// </summary>
        /// <remarks>
        /// Receiving institution bank identifier.
        /// </remarks>
        [Required, StringLength(9, MinimumLength = 9)]
        [RegularExpression(CustomRegex.Num)]
        public string AbaRoutingTransitNumber { get; set; }

        /// <summary>
        /// The amount to be debited or credited to the WIC Vendor identified.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "99999999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal AchPaymentAmount { get; set; }

        /// <summary>
        /// The number identifying the WIC Vendor's bank checking account.
        /// </summary>
        [Required]
        [Range(typeof(long), "0", "99999999999999999")]
        public long BankAccountNumber { get; set; }

        /// <summary>
        /// The business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcSpecSpace)]
        public string BankName { get; set; }

        /// <summary>
        /// A code assigned by the acquirer to identify the WIC Vendor that defines the point of service.
        /// </summary>
        [StringLength(15)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string CardAcceptorIdentificationCode { get; set; }

        /// <summary>
        /// A unique number assigned to a corporation to which WIC Vendors may be associated.
        /// </summary>
        /// <remarks>
        /// Required if payment at a hierarchy level other than the WIC Vendor.
        /// </remarks>
        [Range(typeof(long), "0", "999999999999")]
        public long CorporationId { get; set; }

        /// <summary>
        /// Date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Default is current date.
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// A value indicating the position of the WIC Vendor location within the corporation hierarchy.
        /// </summary>
        /// <remarks>
        /// Default is "no hierarchy".
        /// </remarks>
        [Required, StringLength(1)]
        [Range(typeof(byte), "0", "9")]
        public byte HierarchyCode { get; set; }

        /// <summary>
        /// The original number assigned by the message initiator to uniquely
        /// identify a transaction in WIC redemption processing.
        /// </summary>
        /// <remarks>
        /// Required if this payment is related to a single, previous transaction.
        /// </remarks>
        [Range(typeof(int), "0", "999999")]
        public int OriginalSystemsTraceAuditNumber { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        /// <remarks>
        /// Adjustment, Payment to warehouse, etc.
        /// </remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Code identifying the entity receiving the message or batch.
        /// </summary>
        /// <remarks>
        /// Used by sender as additional identifier for entity receiving the file.
        /// </remarks>
        [Range(typeof(long), "0", "99999999999")]
        public long ReceivingInstitutionIdentificationCode { get; set; }

        /// <summary>
        /// Value assigned by the WIC Management Information System to idenfity the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required, StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }
    }
}