﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Data element that is repeated for each purchase return by GetBenefitRedemptionHistory.
    /// </summary>
    [XmlRoot(ElementName = "BenefitRedemption")]
    public class GetBenefitRedemptionHistoryResultBenefitRedemption
    {
        /// <summary>
        /// Constructor for this class.
        /// </summary>
        public GetBenefitRedemptionHistoryResultBenefitRedemption()
        {
            BenefitRedemptionFoodItems = new List<GetBenefitRedemptionHistoryResultFoodItem>();
        }

        /// <summary>
        /// Gets or sets an object identifying a record and carrying metadata about it.
        /// </summary>
        public BatchRecordHeader RecordHeader { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the entity acquiring the transaction.
        /// </summary>
        /// <remarks>
        /// Identified entity that obtained the transaction from the WIC Vendor.
        /// </remarks>
        [Range(typeof(long), "0", "99999999999")]
        public long? AcquiringInstitutionIdCode { get; set; }

        /// <summary>
        /// Gets or sets the amounts deducted from the gross amount of the transaction due to coupons or other
        /// reductions in the amount and is the absolute value of the discounts for the transaction.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "9999999999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount paid to a WIC Vendor for a purchase transaction less any discounts or adjustments.
        /// The Amount, paid at the transaction level shall equal the sum of the Amount, paid of all of the reported
        /// line items less the Amount, discount at the transaction level. The Amount, paid for an individual line
        /// item is equal to the Original item price as adjusted for Amount, NTE Adjustment and Amount,
        /// adjustment times the approved Purchase quantity; cannot be less than zero.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "9999999999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal PaidAmount { get; set; }

        /// <summary>
        /// Gets or sets the sum of all adjustments made to the item prices of the individual food items for a
        /// transaction.
        /// </summary>
        /// <remarks>
        /// Includes adjustments to the transaction for NTE price or other adjustments.
        /// </remarks>
        [Required]
        [Range(typeof(decimal), "0.0", "99999999999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal TotalAdjustmentsAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount requested by the cardholder in the local currency of the acquirer or source location
        /// of the transaction including any surcharges.
        /// </summary>
        /// <remarks>
        /// Original requested amount
        /// </remarks>
        [Required]
        [Range(typeof(decimal), "0.0", "9999999999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal TransactionAmount { get; set; }

        /// <summary>
        /// Gets or sets a code assigned by the acquirer to identify the WIC Vendor that defines the point of service.
        /// </summary>
        [StringLength(15)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string CardAcceptorIdentificationCode { get; set; }

        /// <summary>
        /// Gets or sets a unique value that identifies the terminal at the WIC Vendor location.
        /// </summary>
        [Required]
        [StringLength(8)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string CardAcceptorTerminalIdentificationCode { get; set; }

        /// <summary>
        /// Gets or sets a series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Required]
        [Range(typeof(ulong), "1000000000000000", "9999999999999999999")]
        public ulong? CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the date/time when a transaction occurred based on date/time of EBT Card Issuer Processor
        /// system expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.TransmissionDT)]
        public string HostDateAndTime { get; set; }

        /// <summary>
        /// Gets or sets the date/time when a transaction occurred based on date and time of WIC Vendor system.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.TransmissionDT)]
        public string LocalTransactionDateAndTime { get; set; }

        /// <summary>
        /// Gets or sets the calendar date on which a transaction occurred or date reported by the EBT system
        /// for the transaction expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string BusinessDate { get; set; }

        /// <summary>
        /// Gets or sets the year, month and day funds are transferred between the acquired and the card issuer
        /// expressed in GMT in accordance with ISO 8601. In WIC EBT, the EBT system's recorded date of settlement.
        /// </summary>
        /// <remarks>
        /// As recored by the EBT system.
        /// </remarks>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string SettlementDate { get; set; }

        /// <summary>
        /// Gets or sets the identity of the institution forwarding the information.
        /// </summary>
        /// <remarks>
        /// Identifies entity that submitted the transaction for payment.
        /// </remarks>
        [Range(typeof(long), "0", "99999999999")]
        public long? ForwardingInstitutionIdCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the result outcome of the ICC read at the POS.
        /// </summary>
        /// <remarks>
        /// Required for WIC Smart Card EBT transactions only.
        /// </remarks>
        [StringLength(6)]
        [RegularExpression(CustomRegex.AbcNumSpec)]
        public string IntegratedCircuitCardResultCode { get; set; }

        /// <summary>
        /// Gets or sets the reason or purpose of the original message.
        /// </summary>
        /// <remarks>
        /// Required if Type code reported is not a purchase; from the WIC auto-reconciliation file
        /// "D4 - detail record" or "E2 - addenda record" or "D5 - adjustment record" for both
        /// WIC Online and Smart Card EBT.
        /// </remarks>
        [StringLength(4)]
        [RegularExpression(CustomRegex.Num)]
        public string MessageReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the original Unique EBT transaction identifier number that was assigned to a redemption
        /// or reversal/void transaction by the WIC EBT system interface.
        /// </summary>
        /// <remarks>
        /// For a reversal, refers to the original transaction.
        /// </remarks>
        [Range(typeof(long), "0", "999999999999999999")]
        public long? OriginalUniqueTransactionId { get; set; }

        /// <summary>
        /// Gets or sets a series of code intended to identify terminal capability, terminal environment
        /// and presentation security data.
        /// </summary>
        [Required]
        public PosDataCode PosDataCode { get; set; }

        /// <summary>
        /// Gets or sets a number assigned by the message initiator to uniquely identify a transaction
        /// in WIC redemption processing
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "999999")]
        public int? SystemsTraceAuditNumber { get; set; }

        /// <summary>
        /// Gets or sets the reason the transaction was declined or adjusted. Value is the Action code (bit 39) for
        /// WIC Online EBT.
        /// </summary>
        /// <remarks>
        /// Required for WIC Online EBT if Type code is not an approved purchase.
        /// Value is the action code (bit 39).
        /// </remarks>
        [StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string TransactionReasonCode { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// Identifies the transaction type (Purchase, Void, Adjustment, etc).
        /// </remarks>
        [Required]
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets a number assigned by the sender that uniquely identifies a transaction within the
        /// WIC MIS and WIC EBT system interface.
        /// </summary>
        /// <remnarks>
        /// For redemptions being reported it contains the host assigned unique identifier
        /// (e.g. an approval code or the Systems trade audit number from the POS).
        /// </remnarks>
        [Range(typeof(long), "0", "999999999999999999")]
        public long? UniqueTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the value assigned by the WIC MIS to identify an account for a WIC participant, economic
        /// unit or household.
        /// </summary>
        [Required]
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Gets or sets the value assigned by the WIC Management Information System to identify the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required]
        [StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }

        /// <summary>
        /// Gets or sets an identifier assigned to a set of vendors defined by the
        /// WIC State Agency for managing cost containment.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "99999")]
        public int WicVendorPeerGroupId { get; set; }

        /// <summary>
        /// Gets or sets the data element that is repeated for each food item in the purchase.
        /// </summary>
        public List<GetBenefitRedemptionHistoryResultFoodItem> BenefitRedemptionFoodItems { get; set; }
    }
}
