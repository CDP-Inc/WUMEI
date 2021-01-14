using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all the parameters returned for the Get Cardholders / Cards method.
    /// </summary>
    public class GetCardholdersCardsResult
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Data object containing elements that are repeated for each card number.
        /// </summary>
        [Required]
        public IList<GetCardholdersCardsResultCardholderCard> CardholderCards { get; set; }
    }
}