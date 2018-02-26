using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters that are returned for the Get Warehouse Authorizations method.
    /// </summary>
    public class GetWarehouseAuthorizationsResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Data element that contains sub-elements that are repeated for each matching authorization.
        /// </summary>
        [Required]
        public IEnumerable<WarehouseAuthorizations> WarehouseAuthorizations { get; set; }
    }
}