using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Data model for the UpdateEba message.
    /// </summary>
    public class UpdateEba
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Activate, Update, Deactive, Hold, etc.
        /// </remarks>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the household receives mail.
        /// </summary>
        public HouseholdMailingAddress HouseholdMailingAddress { get; set; }

        /// <summary>
        /// Gets or sets month, day and year the head of household was born expressed in GMT in accordance
        /// with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets effective date for change expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the person being identified is male or female.
        /// </summary>
        [StringLength(1,MinimumLength =1)]
        [RegularExpression(CustomRegex.Gender)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the preferred language spoken by the person identified.
        /// </summary>
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Abc)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name, middle initial,
        /// last name and suffix.
        /// </summary>
        public HouseholdContactName HeadOfHouseholdName { get; set; }

        /// <summary>
        /// Gets or sets reason for an action.
        /// </summary>
        /// <remarks>
        /// Default to "E001 - new".
        /// </remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets value assigned by the WIC MIS to identify an account for a WIC participant,
        /// economic unit or household.
        /// </summary>
        [Required]
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Gets or sets a new value assigned by the WIC MIS to identify an account for a WIC participant,
        /// economic unit or household.
        /// </summary>
        /// <remarks>
        /// If present, this WIC MIS account ID will be associated to the EBA and the
        /// old WIC MIS account ID will be deactivated.
        /// </remarks>
        [RegularExpression(CustomRegex.AbcNum)]
        [StringLength(19, MinimumLength = 2)]
        public string NewWicMisAccountId { get; set; }
    }
}
