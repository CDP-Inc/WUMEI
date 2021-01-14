using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// The Add Local Agency function is an optional function that uses a message based system interface to
    /// create a local agency information record in the WIC EBT System.
    /// </summary>
    public class AddLocalAgency : V2018.AddLocalAgency
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a date and time when an action is in effect expressed in GMT in accordance with ISO 8601
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [JsonIgnore]
        public override DateTime DateEffective { get; set; }
    }
}