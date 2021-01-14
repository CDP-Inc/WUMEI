using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters required to initiate the generation of an APL File.
    /// </summary>
    public class GenerateAplFile
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the actual or abbreviated name of the file being accessed.
        /// </summary>
        /// <remarks>
        /// The returned APL File. Input parameter is "UPC/PLU Store File."
        /// </remarks>
        [Required, StringLength(40)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string FileName { get; set; }
    }
}