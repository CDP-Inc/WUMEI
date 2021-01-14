using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Update Cardholder or Card method.
    /// </summary>
    public class UpdateCardholderCard : V2018.UpdateCardholderCard
    {
        #region Properties

        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the cardholder receives mail.
        /// </summary>
        public new CardholderMailingAddress CardholderMailingAddress { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name, middle initial,
        /// last name and suffix.
        /// </summary>
        [Required]
        public new CardholderContactName CardholderName { get; set; }

        #endregion Properties
    }
}
