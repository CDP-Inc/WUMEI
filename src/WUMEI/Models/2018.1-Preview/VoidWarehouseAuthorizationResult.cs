using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters returned for the Void Warehouse Authorization Result method.
    /// </summary>
    public class VoidWarehouseAuthorizationResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// The quantity of products that have been requested by a warehouse vendor for the purpose of
        /// a warehouse authorization.
        /// </summary>
        /// <remarks>
        /// The remaining unredeemed quantity for the UPC/PLU data before the current void as been applied.
        /// </remarks>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal AuthorizationQuantity { get; set; }
    }
}
