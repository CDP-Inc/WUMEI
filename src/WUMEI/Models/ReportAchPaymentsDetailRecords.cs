using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Collection of Detail Records for the Report ACH Payments method.
    /// </summary>
    public class ReportAchPaymentsDetailRecords
    {
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
        /// 
        /// </summary>
        [Required]
        [Range(typeof(long), "0", "999999999999999")]
        public long AchTraceNumber { get; set; }

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
        /// Required if payment at a hierarchy level other than WIC Vendor.
        /// </remarks>
        [Range(typeof(long), "0", "999999999999")]
        public long CorporationId { get; set; }

        /// <summary>
        /// Date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// In report, corresponds to NACHA Effective Entry Date assigned by the EBT system.
        /// </remarks>
        [Required]
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// An identifier assigned to a WIC MIS user that is used to track activity in the system.
        /// </summary>
        /// <remarks>
        /// Required if initiated from a local agency.
        /// </remarks>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string InitiatingUserId { get; set; }

        /// <summary>
        /// WIC MIS assigned identifier that uniquely identifies a local agency within the WIC State Agency.
        /// </summary>
        /// <remarks>
        /// Required if original transaction originated from a local agency.
        /// </remarks>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string LocalAgencyId { get; set; }

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
        /// ACH payment reason from original payment being reported.
        /// </remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Code identifying the entity receiving the message or batch.
        /// </summary>
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