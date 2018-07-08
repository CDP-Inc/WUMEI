using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// The following data elements shall be included in both directions of the messages exchanged in a
    /// message based system interface.
    /// </summary>
    /// <remarks>
    /// Function return code is Required in the response.
    /// </remarks>
    public class MessageHeader
    {
        /// <summary>
        /// WIC MIS assigned identifier for a clinic.
        /// </summary>
        /// <remarks>
        /// Required if message originates from a clinic.
        /// </remarks>
        [Range(typeof(long), "0", "9999999999")]
        public long ClinicId { get; set; }

        /// <summary>
        /// Date and time the originator of the function sends the message or batch expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.TransmissionDT)]
        public string TransmissionDateTime { get; set; }

        /// <summary>
        /// A value returned in a message based system interface to explicitly indicate the information
        /// sent was received and the action taken.
        /// </summary>
        /// <remarks>Indicates that a message was received and the result of processing the message.</remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.Num)]
        public string FunctionReturnCode { get; set; }

        /// <summary>
        /// Text description associated with Function return code.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string FunctionReturnText { get; set; }

        /// <summary>
        /// An identifier assigned to a WIC MIS user that is used to track activity in the system.
        /// </summary>
        /// <remarks>
        /// Required if Clinic ID present.
        /// </remarks>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string InitiatingUserId { get; set; }

        /// <summary>
        /// WIC MIS assigned identifier that uniquely identifies a local agency within the WIC State Agency.
        /// </summary>
        /// <remarks>
        /// Required if message originates from a local agency.
        /// </remarks>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string LocalAgencyId { get; set; }

        /// <summary>
        /// A value that identifies the function being performed.
        /// </summary>
        [Required, StringLength(4)]
        [RegularExpression(CustomRegex.Num)]
        public string MessageOrFileTypeCode { get; set; }

        /// <summary>
        /// A value that identifies which version of a message is being used in a message based system interface.
        /// </summary>
        [Required, StringLength(20)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string MessageVersion { get; set; }

        /// <summary>
        /// A number assigned by the sender that uniquely identifies a transaction within the WIC MIS and
        /// WIC EBT system interface.
        /// </summary>
        /// <remarks>Assigned by sender, echoed in response.</remarks>
        [Required]
        [Range(typeof(long), "0", "999999999999999999")]
        public long UniqueTransactionId { get; set; }

        /// <summary>
        /// String used to identify user in the WIC EBT System. Used in conjunction with the
        /// WIC EBT System ID to uniquely identify a user.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpec)]
        public string Username { get; set; }

        /// <summary>
        /// Value identifying the WIC EBT system.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string WicEbtSystemId { get; set; }

        /// <summary>
        /// Value identifying  the WIC Management Information System.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string WicMisSystemId { get; set; }

        /// <summary>
        /// Value assigned by FNS to identify the WIC Authority.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string WicStateAgencyId { get; set; }

        /// <summary>
        /// A value identifying the workstation initiating the function.
        /// </summary>
        /// <remarks>
        /// Required if Clinic ID present.
        /// </remarks>
        [StringLength(20)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WorkstationId { get; set; }
    }
}
