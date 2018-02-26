using System;
using System.ComponentModel.DataAnnotations;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// Object that contains all paramters required for the Get EBA Details method.
    /// </summary>
    public class GetEbaUsingCardNumber
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the 
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        [Required, StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }
    }
}