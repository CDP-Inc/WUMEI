using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// At least one of the optional data elements shown shall be provided to
    /// identify the record(s) to be retrieved.
    /// </summary>
    public class GetCardholdersCards
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the card holder receives mail.
        /// </summary>
        /// <remarks>
        /// If used, note that formatting of address information may result in mismatches.
        /// </remarks>
        public CardholderMailingAddress CardholderMailingAddress { get; set; }

        /// <summary>
        /// Gets or sets a series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Range(typeof(ulong), "1000000000000000", "9999999999999999999")]
        public ulong? CardNumber { get; set; }

        /// <summary>
        /// Gets or sets month, day, and year the card holder was born expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public string CardholderDateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets beginning of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public virtual string BeginRequestDate { get; set; }

        /// <summary>
        /// Gets or sets end of period being referenced for this function expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public virtual string EndRequestDate { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name, middle initial, last name and suffix.
        /// </summary>
        public CardholderContactName CardholderName { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the status of the entity indicated.
        /// </summary>
        /// <remarks>
        /// May only be used with an optional data element to request a card in a specific status
        /// (Lost, Stolen, Valid, Activated, Deactivated, etc).
        /// </remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// May only be used with an optional data element to request a specific cardholder type
        /// (Primary, Secondary, Proxy).
        /// </remarks>
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets a value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }
    }
}
