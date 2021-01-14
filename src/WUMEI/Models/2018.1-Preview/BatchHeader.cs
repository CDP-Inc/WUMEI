namespace WUMEI.Models.V2018
{
    /// <summary>
    /// The following data elements shall be included in each batch system interface at the file level.
    /// </summary>
    public class BatchHeader
    {
        /// <summary>
        /// Gets or sets the count of detail records contained in the file.
        /// </summary>
        public int DetailRecordsCount { get; set; }

        /// <summary>
        /// Gets or sets the date and time the originator of the function sends the message or batch expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// File create date and time, in GMT.
        /// </remarks>
        public string TransmissionDateTime { get; set; }

        /// <summary>
        /// Gets or sets the actual or abbreviated name of the file being accessed.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets a unique number that is incremented by 1 for each file that is successfully transferred.
        /// </summary>
        public int FileSequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the standard on which the records within the file are based.
        /// </summary>
        public int FileFormatVersion { get; set; }

        /// <summary>
        /// Gets or sets a value that indentifies the function being performed.
        /// </summary>
        public short FileTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the entity that is sending the file.
        /// e.g. Forwarding institution ID, WIC EBT system ID or WIC MIS SystemID.
        /// </summary>
        public long OriginatorOfFile { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the entity receiving the message or batch.
        /// </summary>
        /// <remarks>
        /// Receiving institution ID code, WIC State Agency ID or BIN.
        /// </remarks>
        public long ReceivingInstitutionIdentificationCode { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// The type of file.
        /// </remarks>
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets a value assigned by FNS to identify the WIC Authority.
        /// </summary>
        public short WicStateAgencyId { get; set; }
    }
}
