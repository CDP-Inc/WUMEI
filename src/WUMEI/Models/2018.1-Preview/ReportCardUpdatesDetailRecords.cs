using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Collection of Detail Records for the Report Card Updates method.
    /// </summary>
    public class ReportCardUpdatesDetailRecords
    {
        /// <summary>
        /// Gets or sets an object identifying a record and carrying metadata about it.
        /// </summary>
        public BatchRecordHeader RecordHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Action code indicated in original update record (Activate, Deactivate, etc).
        /// </remarks>
        [Required]
        [Range(typeof(short), "0", "999")]
        public short ActionCode { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the card holder receives mail.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder.
        /// </remarks>
        public CardholderMailingAddress CardholderMailingAddress { get; set; }

        /// <summary>
        /// Gets or sets a description of the unique relationship of the WIC Cardholder
        /// to an account to an account or the WIC Participant.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder.
        /// </remarks>
        [StringLength(30)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string CardholderRelationship { get; set; }

        /// <summary>
        /// Gets or sets a series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Required]
        [Range(typeof(ulong), "0", "9999999999999999999")]
        public ulong CardNumber { get; set; }

        /// <summary>
        /// Gets or sets a series of digits used to identify the new customer account or relationship.
        /// </summary>
        /// <remarks>
        /// Required when card was replaced.
        /// </remarks>
        [Range(typeof(ulong), "0", "9999999999999999999")]
        public ulong? ReplacementCardNumber { get; set; }

        /// <summary>
        /// Gets or sets date when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets date/time when a transaction occurred based on date/time of EBT Card Issuer Processor
        /// system expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if update performed at the WIC EBT system.
        /// </remarks>
        public DateTime HostDateAndTime { get; set; }

        /// <summary>
        /// Gets or sets date/time when a transaction occurred based on date and time of WIC Vendor system.
        /// </summary>
        /// <remarks>
        /// Required if update performed at POS.
        /// </remarks>
        public DateTime LocalTransactionDateAndTime { get; set; }

        /// <summary>
        /// Gets or sets month, day and year the cardholder was born expressed in GMT
        /// in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder.
        /// </remarks>
        public DateTime CardholderDateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the person being identified is male or female.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder.
        /// </remarks>
        [StringLength(1)]
        [RegularExpression(CustomRegex.Abc)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets an identifier assigned to a WIC MIS user that is used to track activity in the system.
        /// </summary>
        /// <remarks>
        /// If action originated by WIC MIS system, identifies the user that initiated the action.
        /// </remarks>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string InitiatingUserId { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the preferred language spoken by the person identified.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder.
        /// </remarks>
        [StringLength(3)]
        [RegularExpression(CustomRegex.Abc)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name, middle initial,
        /// last name and suffix.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder.
        /// </remarks>
        public CardholderContactName CardholderName { get; set; }

        /// <summary>
        /// Gets or sets a code identifying changes made to the PIN associated with the card.
        /// </summary>
        [StringLength(4)]
        [RegularExpression(CustomRegex.Num)]
        public string PinActivityCode { get; set; }

        /// <summary>
        /// Gets or sets phone number for cardholder.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder.
        /// </remarks>
        [StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string CardholderPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the reason for an action.
        /// </summary>
        /// <remarks>
        /// Reason code sent with the action indicated.
        /// </remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the status of the entity indicated.
        /// </summary>
        /// <remarks>
        /// Resulting Status code from the action indicated.
        /// </remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// Cannot be changed by WIC EBT system, only reported.
        /// </remarks>
        [Required, StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets value assigned by the WIC MIS to identify an account for a WIC participant,
        /// economic unit or household.
        /// </summary>
        [Required, StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }
    }
}