using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Update Cardholder or Card method.
    /// </summary>
    public class UpdateCardholderCard
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Activate, Deactive, etc.
        /// </remarks>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the cardholder receives mail.
        /// </summary>
        public CardholderMailingAddress CardholderMailingAddress { get; set; }

        /// <summary>
        /// A description of the unique relationship of the WIC Cardholder
        /// to an account to an account or the WIC Participant.
        /// </summary>
        [StringLength(30)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string CardholderRelationship { get; set; }

        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        /// <remarks>
        /// Original card being replaced.
        /// </remarks>
        [Required]
        [StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }

        /// <summary>
        /// A series of digits used to identify the new customer account or relationship.
        /// </summary>
        /// <remarks>
        /// Required if replacing card, new card number.
        /// </remarks>
        [StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string ReplacementCardNumber { get; set; }

        /// <summary>
        /// Date and time when an action is in effect expressed in GMT in accordance with ISO 8601
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string DateEffective { get; set; }

        /// <summary>
        /// Month, day and year the cardholder was born expressed in GMT
        /// in accordance with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public string CardholderDateOfBirth { get; set; }

        /// <summary>
        /// A value indicating whether the person being identified is male or female.
        /// </summary>
        [StringLength(1)]
        [RegularExpression(@"^(M|F){1}$")]
        public string Gender { get; set; }

        /// <summary>
        /// A code indicating the preferred language spoken by the person identified.
        /// </summary>
        [StringLength(3)]
        [RegularExpression(CustomRegex.Abc)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements first name, middle initial, last name and suffix.
        /// </summary>
        [Required]
        public CardholderContactName CardholderName { get; set; }

        /// <summary>
        /// Phone number for cardholder.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string CardholderPhoneNumber { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        [Required]
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// A code indicating the status of the entity indicated.
        /// </summary>
        /// <remarks>
        /// Indicates result, Activated, Deactivated, etc
        /// Required if changing the status of the card. If a replacement, status of the card being replaced,
        /// e.g. Lost, Stolen.
        /// </remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string StatusCode { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// Required if changing the Cardholder type (Primary, Secondary, Proxy),
        /// </remarks>
        [Required]
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        [Required]
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }
    }
}