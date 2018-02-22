using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters that are returned for the Request Warehouse Authorization method.
    /// </summary>
    public class RequestWarehouseAuthorizationResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Code to be presented in redemptions against warehouse authorizations.
        /// </summary>
        [Required, StringLength(4)]
        [RegularExpression(CustomRegex.Num)]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// The quantity of products that have been requested by a warehouse vendor for the purpose of
        /// a warehouse authorization.
        /// </summary>
        /// <remarks>
        /// The remaining unredeemed quantity for the UPC/PLU data after the curent request has been applied.
        /// </remarks>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal AuthorizationQuantity { get; set; }

        /// <summary>
        /// A series of digits appearing on the face of the WIC Card or encoded on the 
        /// magnetic stripe of a card or assigned to a SmartCard.
        /// </summary>
        /// <remarks>
        /// The primary card associated with the account.
        /// </remarks>
        [Required, StringLength(19)]
        [RegularExpression(CustomRegex.Num)]
        public string CardNumber { get; set; }
    }
}