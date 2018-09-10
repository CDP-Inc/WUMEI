﻿using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters required for the Add Update Pin method.
    /// </summary>
    public class AddUpdatePin
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A code which defines the action to be taken.
        /// </summary>
        [Required]
        [Range(typeof(short), "0", "999")]
        public short ActionCode { get; set; }

        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Required]
        [Range(typeof(ulong), "0", "9999999999999999999")]
        public ulong CardNumber { get; set; }

        /// <summary>
        /// A number assigned to a cardholder intended to uniquely identify that
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