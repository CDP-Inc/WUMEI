using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// The Add Clinic function is an optional function that uses a message based system interface to add a clinic
    /// information record in the WIC EBT System.
    /// </summary>
    public class AddClinic : V2018.AddClinic
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [JsonIgnore]
        public override DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets the times of day when entity is available.
        /// </summary>
        [StringLength(12, MinimumLength = 12)]
        [RegularExpression(CustomRegex.Num)]
        [JsonIgnore]
        public override string OperationHours { get; set; }
    }
}