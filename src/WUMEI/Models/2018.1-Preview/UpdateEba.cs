using System;
using System.ComponentModel.DataAnnotations;
using WUMEI.Models._2018._1_Preview;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Update EBA method.
    /// </summary>
    public class UpdateEba
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
        /// Activate, Update, Deactive, Hold, etc.
        /// </remarks>
        [Required]
        [Range(typeof(short), "0", "999")]
        public short ActionCode { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the household receives mail.
        /// </summary>
        public HouseholdMailingAddress HouseholdMailingAddress { get; set; }

        /// <summary>
        /// Month, day and year the head of household was born expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [RegularExpression(CustomRegex.StandardDate)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public DateTime EffectiveDate { get; set; }

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
        public HouseholdContactName HeadOfHouseholdName { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        [Required]
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// New value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        /// <remarks>
        /// IF present, this WIC MIS account ID will be associated to the EBA and the
        /// old WIC MIS account ID will be deactivated.
        /// </remarks>
        [StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string NewWicMisAccountId { get; set; }
    }
}
