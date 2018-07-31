using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models._2018._1_Preview
{
    public class BenefitMaintenanceHistoryDetails
    {
        /// <summary>
        ///   Add or subtract; see Appendix B.1 for values, echoed from the original message if the benefit update was
        ///   initiated by the MIS using Add or Update Benefits (purges are not typically MIS initiated)
        /// </summary>
        /// <remarks>
        ///   A code which defines the action to be taken. See Appendix B.1 for values.
        /// </remarks>
        public string ActionCode { get; set; }

        /// <summary>
        ///   A series of digits appearing on the face of the WIC Card or encoded on the magnetic stripe of a card
        ///   or assigned to a Smart Card.
        /// </summary>
        /// <remarks>
        ///   Mandatory if WicMisAccountID is not present
        /// </remarks>
        public string CardNumber { get; set; }

        /// <summary>
        ///   WIC MIS assigned identifier for a clinic.
        /// </summary>
        /// <remarks>
        ///   Echoed from original message if present
        /// </remarks>
        public decimal? ClinicId { get; set; }

        /// <summary>
        ///   An identifier assigned to a WIC MIS user that is used to track activity in the system.
        /// </summary>
        public string InitiatingUserId { get; set; }

        /// <summary>
        ///   WIC MIS assigned identifier that uniquely identifies a local agency within the WIC State Agency.
        /// </summary>
        public string LocalAgencyId { get; set; }

        /// <summary>
        ///   Provides the reason the transaction was declined or adjusted. Value is the action code (bit 39) for
        ///   WIC Online EBT and the message reason code from claim file “D4 – detail record” for WIC Smart Card EBT;
        ///   see Technical Implementation Guide for corresponding values.
        /// </summary>
        public string ReasonCode { get; set; }

        /// <summary>
        ///   A code indicating the kind of entity being acted or reported upon in the function.
        ///   See Appendix B.7 for values.
        /// </summary>
        public string TypeCode { get; set; }

        /// <summary>
        ///   A number that uniquely identifies the transaction.
        /// </summary>
        public string UniqueTransactionId { get; set; }

        /// <summary>
        ///   String used to identify user in the WIC EBT System.
        ///   Used in conjunction with the WIC EBT System ID to uniquely identify a user.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///   Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household
        /// </summary>
        public string WicMisAccountId { get; set; }

        /// <summary>
        ///   A string identifying the workstation initiating the function.
        /// </summary>
        public string WorkstationId { get; set; }

        /// <summary>
        ///   Benefit Issuance Id.
        /// </summary>
        /// <remarks>
        ///   This is the benefit issuance id range from 0 to 999,999,999,999.
        /// </remarks>
        public decimal? BenefitIssuanceId { get; set; }

        /// <summary>
        /// Sequence Id
        /// </summary>
        public int? BenefitIssuanceSequenceId { get; set; }

        /// <summary>
        /// Host DateTime
        /// </summary>
        public DateTime HostDateTime { get; set; }

        /// <summary>
        ///   Benefit Start Date.
        /// </summary>
        /// <remarks>
        ///   Start date for the benefit
        /// </remarks>
        public string BenefitBeginDate { get; set; }

        /// <summary>
        ///   Benefit End Date.
        /// </summary>
        /// <remarks>
        ///   End date for the benefit
        /// </remarks>
        public string BenefitEndDate { get; set; }

        /// <summary>
        /// Category details
        /// </summary>
        public List<BenefitMaintenanceHistoryCategoryDetails> BenefitHistoryCategoryDetails { get; set; }
    }
}
