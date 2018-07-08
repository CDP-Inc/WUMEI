using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Get EBA Details method response.
    /// </summary>
    public class GetEbaDetailsResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the household receives mail.
        /// </summary>
        /// <remarks>
        /// Required if provided when the EBA was added or updated.
        /// </remarks>
        public MailingAddressOp HouseholdMailingAddress { get; set; }

        /// <summary>
        /// Month, day and year the head of household was born expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if provided when the EBA was added or updated.
        /// </remarks>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// A value indicating whether the person being identified is male or female.
        /// </summary>
        /// <remarks>
        /// Required if provided when the EBA was added or updated.
        /// </remarks>
        [StringLength(1)]
        [RegularExpression(CustomRegex.Abc)]
        public string Gender { get; set; }

        /// <summary>
        /// A code indicating the preferred language spoken by the person identified.
        /// </summary>
        /// <remarks>
        /// Required if provided when the EBA was added or updated.
        /// </remarks>
        [StringLength(3)]
        [RegularExpression(CustomRegex.Abc)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements first name, middle initial, last name and suffix.
        /// </summary>
        /// <remarks>
        /// Required if provided when the EBA was added or updated.
        /// </remarks>
        public ContactName HeadOfHouseholdName { get; set; }

        /// <summary>
        /// A code indicating the status of the entity indicated.
        /// </summary>
        /// <remarks>Indicates result, Activated, Deactivated, etc</remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string StatusCode { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        [Required, StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        [Required, StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }
    }
}
