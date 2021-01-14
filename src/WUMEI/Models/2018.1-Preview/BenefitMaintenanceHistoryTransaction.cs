using System.Collections.Generic;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// A class representing a benefit maintenance transaction.
    /// </summary>
    public class BenefitMaintenanceHistoryTransaction
    {
        /// <summary>
        /// Gets or sets the action code. Add or subtract; see Appendix B.1 for values, echoed from the original
        /// message if the benefit update was initiated by the MIS using Add or Update Benefits
        /// (purges are not typically MIS initiated)
        /// </summary>
        /// <remarks>
        /// A code which defines the action to be taken. See Appendix B.1 for values.
        /// </remarks>
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets the series of digits appearing on the face of the WIC Card or encoded on the magnetic stripe
        /// of a card or assigned to a Smart Card.
        /// </summary>
        /// <remarks>
        /// Mandatory if WicMisAccountID is not present
        /// </remarks>
        public ulong? CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the WIC MIS assigned identifier for a clinic.
        /// </summary>
        /// <remarks>
        /// Echoed from original message if present
        /// </remarks>
        public string ClinicId { get; set; }

        /// <summary>
        /// Gets or sets an identifier assigned to a WIC MIS user that is used to track activity in the system.
        /// </summary>
        public string InitiatingUserId { get; set; }

        /// <summary>
        /// Gets or sets the WIC MIS assigned identifier that uniquely identifies a local agency within the WIC State
        /// Agency.
        /// </summary>
        public string LocalAgencyId { get; set; }

        /// <summary>
        /// Gets or sets the reason the transaction was declined or adjusted. Value is the action code (bit 39) for
        /// WIC Online EBT and the message reason code from claim file “D4 – detail record” for WIC Smart Card EBT;
        /// see Technical Implementation Guide for corresponding values.
        /// </summary>
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets the code indicating the kind of entity being acted or reported upon in the function.
        /// See Appendix B.7 for values.
        /// </summary>
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets the number that uniquely identifies the transaction.
        /// </summary>
        public long? UniqueTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the value assigned by the WIC MIS to identify an account for a WIC participant, economic unit
        /// or household
        /// </summary>
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// Gets or sets the ID for the workstation initiating the function.
        /// </summary>
        public string WorkstationId { get; set; }

        /// <summary>
        /// Gets or sets the list of transaction details.
        /// </summary>
        public List<BenefitMaintenanceHistoryTransactionDetails> TransactionDetails { get; set; }
    }
}
