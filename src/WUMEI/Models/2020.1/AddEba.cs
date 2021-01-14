using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Data model for the AddEba message.
    /// </summary>
    public class AddEba : V2018.AddEba
    {
        #region Properties

        /// <summary>
        /// Gets or sets constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the household receives mail.
        /// </summary>
        public new HouseholdMailingAddress HouseholdMailingAddress { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name, middle initial,
        /// last name and suffix.
        /// </summary>
        public new HouseholdContactName HeadOfHouseholdName { get; set; }

        /// <summary>
        /// Gets or sets reason for an action. This property is not used in 2020.1 interface definition
        /// </summary>
        [JsonIgnore]
        public override string ReasonCode { get; set; }

        #endregion Properties
    }
}
