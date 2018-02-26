using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// The following data elements shall be included in each batch system interface at the file level
    /// and at the record level.
    /// </summary>
    public class BatchHeader
    {
        /// <summary>
        /// Count of detail records contained in the file.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "999999999")]
        public int DetailRecordsCount { get; set; }

        /// <summary>
        /// Date and time the originator of the function sends the message or batch expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// File create date and time, in GMT.
        /// </remarks>
        [Required]
        public DateTime TransmissionDateTime { get; set; }

        /// <summary>
        /// The actual or abbreviated name of the file being accessed.
        /// </summary>
        [StringLength(40)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string FileName { get; set; }

        /// <summary>
        /// A unique number that is incremented by 1 for each file that is successfully transferred.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "999999")]
        [RegularExpression(CustomRegex.Num)]
        public int FileSequenceNumber { get; set; }

        /// <summary>
        /// The standard on which the record within the file are based.
        /// </summary>
        [Required, StringLength(2)]
        public string FileFormatVersion { get; set; }

        /// <summary>
        /// A value that indentifies the function being performed.
        /// </summary>
        [Required]
        [Range(typeof(short), "0", "9999")]
        public short FileTypeCode { get; set; }

        /// <summary>
        /// Unique identifier of the entity that is sending the file.
        /// e.g. Forwarding institution ID, WIC EBT system ID or WIC MIS SystemID.
        /// </summary>
        [Required]
        [Range(typeof(short), "0", "99999999999")]
        public long OriginatorofFile { get; set; }

        /// <summary>
        /// Code identifying the entity receiving the message or batch.
        /// </summary>
        /// <remarks>
        /// Receiving institution ID code, WIC State Agency ID or BIN.
        /// </remarks>
        [Required]
        [Range(typeof(long), "0", "99999999999")]
        public long ReceivingInstitutionIdentificationCode { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// The type of file.
        /// </remarks>
        [Required, StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Value assigned by FNS to identify the WIC Authority.
        /// </summary>
        [Required, StringLength(3)]
        [RegularExpression(CustomRegex.Num)]
        public string WicStateAgencyId { get; set; }

        /// <summary>
        /// A sequential number assigned to each record within a batch by the batch sender.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "999999")]
        public int RecordSequenceNumber { get; set; }

        /// <summary>
        /// String used to identify user in the WIC EBT System. Used in conjunction with the 
        /// WIC EBT System ID to uniquely identify a user.
        /// </summary>
        /// <remarks>
        /// Required if record was created as the result of an action by a WIC EBT system user.
        /// </remarks>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpec)]
        public string Username { get; set; }

        /// <summary>
        /// A value identifying the workstation initiating the function.
        /// </summary>
        /// <remarks>
        /// Required if record was created as the result of an action by a user.
        /// </remarks>
        [StringLength(20)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WorkstationId { get; set; }
    }
}
