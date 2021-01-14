using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Objects of this class will hold the results of GetCardHistory method.
    /// </summary>
    public class GetCardHistoryResult
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the list of card history details.
        /// </summary>
        public List<CardHistoryDetails> CardHistoryDetails { get; set; }
    }
}
