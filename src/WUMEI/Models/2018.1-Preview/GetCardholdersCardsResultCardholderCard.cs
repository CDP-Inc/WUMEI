using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains the data returned for each Cardholder/Card
    /// </summary>
    public class GetCardholdersCardsResultCardholderCard
    {
        /// <summary>
        /// A constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the card holder receives mail.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder
        /// </remarks>
        public CardholderMailingAddress CardholderMailingAddress { get; set; }

        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Required]
        [StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }

        /// <summary>
        /// A description of the unique relationship of the WIC Cardholder
        /// to an account to an account or the WIC Participant.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder
        /// </remarks>
        [StringLength(30)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string CardholderRelationship { get; set; }

        /// <summary>
        /// Date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// The date the card/cardholder being reported was last updated.
        /// </remarks>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Month, day and year the cardholder was born expressed in GMT
        /// in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string CardholderDateOfBirth { get; set; }

        /// <summary>
        /// A value indicating whether the person being identified is male or female.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder
        /// </remarks>
        [StringLength(1)]
        [RegularExpression(CustomRegex.Abc)]
        public string Gender { get; set; }

        /// <summary>
        /// A code indicating the preferred language spoken by the person identified.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder
        /// </remarks>
        [StringLength(3)]
        [RegularExpression(CustomRegex.Abc)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements first name, middle initial, last name and suffix.
        /// </summary>
        /// <remarks>
        /// Middle initial and suffix required if the data element was provided in
        /// Add Cardholder/Card or Update Card/Cardholder
        /// </remarks>
        [Required]
        public CardholderContactName CardholderName { get; set; }

        /// <summary>
        /// Phone number for cardholder.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder
        /// </remarks>
        [StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string CardholderPhoneNumber { get; set; }

        /// <summary>
        /// A code identifying whether the PIN associated with the card is locked or unlocked.
        /// </summary>
        [StringLength(1)]
        [RegularExpression(CustomRegex.Abc)]
        public string PinStatusCode { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        /// <remarks>
        /// Original Reason code (Issued, Lost, Returned, etc.) sent with the action.
        /// </remarks>
        [Required]
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// A code indicating the status of the entity indicated.
        /// </summary>
        /// <remarks>
        /// Activated, Valid, etc.
        /// </remarks>
        [Required]
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string StatusCode { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// Cardholder type (Primary, Secondary, and Proxy).
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
