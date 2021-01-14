using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// The following data elements shall be included in both directions of the messages exchanged in a message based
    /// system interface.
    /// </summary>
    /// <remarks>
    /// Function return code is required in the response.
    /// </remarks>
    public class MessageHeader : V2018.MessageHeader
    {
        #region Properties

        /// <summary>
        /// Gets or sets a number assigned by the sender that uniquely identifies a transaction within the WIC MIS and
        /// WIC EBT system interface.
        /// </summary>
        /// <remarks>
        /// Assigned by sender, echoed in response.
        /// </remarks>
        [Required]
        [JsonProperty(PropertyName = "uniqueMessageId")]
        [Range(typeof(long), "0", "999999999999999999")]
        public override long UniqueTransactionId { get; set; } = -1;

        #endregion Properties
    }
}
