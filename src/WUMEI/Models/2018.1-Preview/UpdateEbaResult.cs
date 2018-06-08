using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all paramters required for the Update EBA method response.
    /// </summary>
    public class UpdateEbaResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A code indicating the status of the entity indicated.
        /// </summary>
        /// <remarks>Indicates result, Activated, Deactivated, etc.</remarks>
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string StatusCode { get; set; }
    }
}
