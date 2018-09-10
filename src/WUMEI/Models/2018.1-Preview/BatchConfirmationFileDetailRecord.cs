namespace WUMEI.Models
{
    /// <summary>
    /// Object to hold the details for a error found during the processing of a file to be reflected in the
    /// confirmation file.
    /// </summary>
    public class BatchConfirmationFileDetailRecord
    {
        /// <summary>
        /// Gets or sets the function return code for the error encountered.
        /// </summary>
        public string FunctionReturnCode { get; set; }

        /// <summary>
        /// Gets or sets the function return text for the error encountered.
        /// </summary>
        public string FunctionReturnText { get; set; }

        /// <summary>
        /// Gets or sets the line number in the incoming file of the element that caused the error.
        /// </summary>
        public int OriginalLineNumber { get; set; }

        /// <summary>
        /// Gets or sets the record sequence number of the record that contained the element that caused the error,
        /// if one is available.
        /// </summary>
        public int RecordSequenceNumber { get; set; }
    }
}