using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters returned for the Get Benefit Maintenance History method.
    /// </summary>
    public class GetBenefitMaintenanceHistoryResult
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
        /// Note that purges initiated by the WIC EBT System are not returned.
        /// </remarks>
        [Required, StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the 
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        /// <remarks>
        /// Echoed from original message if present.
        /// </remarks>
        [StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }

        /// <summary>
        /// WIC MIS assigned identifier for a clinic.
        /// </summary>
        /// <remarks>
        /// Echoed from original message if present.
        /// </remarks>
        [Range(typeof(int), "0", "9999999999")]
        public int ClinicId { get; set; }

        /// <summary>
        /// Date and time the originator of the function sends the message or batch expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        [Required]
        public DateTime TransmissionDateTime { get; set; }

        /// <summary>
        /// An identifier assigned to a WIC MIS user that is used to track activity in the system.
        /// </summary>
        /// <remarks>
        /// Echoed from original message if sent.
        /// </remarks>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string InitiatingUserId { get; set; }

        /// <summary>
        /// WIC MIS assigned identifier that uniquely identifies a local agency within the WIC State Agency.
        /// </summary>
        /// <remarks>
        /// Echoed from original message if sent.
        /// </remarks>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string LocalAgencyId { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        /// <remarks>
        /// Echoed from original message if sent.
        /// </remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        [Required, StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// A number assigned by the sender that uniquely identifies a transaction within the
        /// WIC MIS and WIC EBT system interface.
        /// </summary>
        /// <remarks>
        /// Identifies the Unique EBT transaction identifier that was assigned to the transaction being reported.
        /// </remarks>
        [Required]
        [Range(typeof(long), "0", "999999999999999999")]
        public long UniqueTransactionId { get; set; }

        /// <summary>
        /// Value assigned by the WIC MIS to identify an account for a WIC participant, economic unit or household.
        /// </summary>
        [Required, StringLength(19, MinimumLength = 2)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisAccountId { get; set; }

        /// <summary>
        /// A value identifying the workstation initiating the function.
        /// </summary>
        /// <remarks>
        /// Echoed from original message if present.
        /// </remarks>
        [StringLength(20)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WorkStationId { get; set; }

        /// <summary>
        /// Data element that is repeated for each Benefit issuance ID.
        /// </summary>
        [Required]
        public IEnumerable<BenefitBalance> BenefitBalance { get; set; }

    }
}