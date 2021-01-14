namespace WUMEI.Models.V2018
{
    /// <summary>
    /// A class which contains results from GetCardHistory method
    /// </summary>
    public class CardHistoryDetails
    {
        /// <summary>
        /// Gets or sets the original action being reported (Activate, Deactivate, etc.). See Appendix
        /// B.1 for values.
        /// </summary>
        /// <remarks>
        /// A code which defines the action to be taken. See Appendix B.1 for values.
        /// </remarks>
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets the cardholder relationship to the participant. Mandatory if the data element
        /// was updated for the activity being reported.
        /// </summary>
        /// <remarks>
        /// Field that defines the relationship of the cardholder (primary, secondary, etc.)
        /// </remarks>
        public string CardholderRelationship { get; set; }

        /// <summary>
        /// Gets or sets series of digits appearing on the face of the WIC Card or encoded on the magnetic
        /// stripe of a card or assigned to a Smart Card.
        /// </summary>
        /// <remarks>
        /// Card number effected by report transaction.
        /// </remarks>
        public ulong CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the card number that replaced the previous card.
        /// </summary>
        /// <remarks>
        /// Card number of replacement card for card replacement transactions.
        /// </remarks>
        public ulong? ReplacementCardNumber { get; set; }

        /// <summary>
        /// Gets or sets the date/time when a transaction occured based on date/time of EBT Card
        /// Issuer Processor system expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if update completed by WIC EBT system.
        /// </remarks>
        public string HostDateTime { get; set; }

        /// <summary>
        /// Gets or sets the date/time when a transaction occurred based on date and time of WIC Vendor system.
        /// </summary>
        /// <remarks>
        /// Required if update completed at POS.
        /// </remarks>
        public string LocalTransactionDateTime { get; set; }

        /// <summary>
        /// Gets or sets the date and time when an action is in effect expressed in GMT in accordance
        /// with ISO 8601.
        /// </summary>
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets an identifier assigned to a WIC MIS user that is used to track activity
        /// in the system.
        /// </summary>
        public string InitiatingUserId { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name,
        /// middle initial, last name and suffix.
        /// </summary>
        public CardholderContactName CardholderName { get; set; }

        /// <summary>
        /// Gets or sets a code identifying changes made to the PIN associated with the card.
        /// See Appendix B.6 for values.
        /// </summary>
        /// <remarks>
        /// Mandatory if transaction is for a PIN activity.
        /// </remarks>
        public string PinActivityCode { get; set; }

        /// <summary>
        /// Gets or sets the reason code for the transaction. See Appendix B.8 for values.
        /// </summary>
        /// <remarks>
        /// Mandatory if the data element was updated for the activity being reported.
        /// </remarks>
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the code indicating the status of the entity indicated. See Appendix B.9 for values.
        /// </summary>
        /// <remarks>
        /// Mandatory if the data element was updated for the activity being reported.
        /// </remarks>
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the resulting card holder type from the action indicated.
        /// </summary>
        /// <remarks>
        /// Cardholder type (Primary, Secondary, and Proxy). See Appendix B.10 for values.
        /// </remarks>
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets a value assigned by the WIC MIS to identify an account for a WIC participant.
        /// </summary>
        public string WicMisAccountId { get; set; }
    }
}
