using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters required to initiate the generation of a Hot Card List .
    /// </summary>
    public class GenerateHotCardList
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the identity of the file to be generated.
        /// </summary>
        [Required, StringLength(40)]
        [RegularExpression(CustomRegex.Abc)]
        public string FileName { get; set; }
    }
}