using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required to initiate the generation of a Hot Card List .
    /// </summary>
    public class GenerateHotCardList
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Identifies the file to be generated.
        /// </summary>
        [Required, StringLength(40)]
        [RegularExpression(CustomRegex.Abc)]
        public string FileName { get; set; }
    }
}