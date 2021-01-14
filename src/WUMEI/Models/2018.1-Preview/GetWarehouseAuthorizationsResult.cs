using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters that are returned for the Get Warehouse Authorizations method.
    /// </summary>
    public class GetWarehouseAuthorizationsResult
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a data element that contains sub-elements that are repeated for each matching authorization.
        /// </summary>
        [Required]
        public IEnumerable<WarehouseAuthorizations> WarehouseAuthorizations { get; set; }
    }
}