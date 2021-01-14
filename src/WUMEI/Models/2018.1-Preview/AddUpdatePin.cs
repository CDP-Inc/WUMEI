using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters required for the Add Update Pin method.
    /// </summary>
    public class AddUpdatePin
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// Gets or sets a series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Required]
        [Range(typeof(ulong), "1000000000000000", "9999999999999999999")]
        public ulong CardNumber { get; set; }

        /// <summary>
        /// Gets or sets a number assigned to a cardholder intended to uniquely identify that
        /// cardholder at the point of service; encrypted block.
        /// </summary>
        /// <remarks>
        /// Required when used to add or update the value of the PIN. May required additional
        /// data elements as defined by bilateral agreement depending on encryption methodology used.
        /// </remarks>
        [StringLength(72)]
        [RegularExpression(CustomRegex.Hex)]
        public string EncryptedPin { get; set; }
    }
}
