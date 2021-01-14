using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// At least one of the optional data elements shown shall be provided to identify the record(s) to be retrieved.
    /// </summary>
    public class GetCardholdersCards : V2018.GetCardholdersCards
    {
        #region Properties

        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a begin request date. This property is not used in the 2020.1 interface definition.
        /// </summary>
        [JsonIgnore]
        public override string BeginRequestDate { get; set; }

        /// <summary>
        /// Gets or sets an end request date. This property is not used in the 2020.1 interface definition.
        /// </summary>
        [JsonIgnore]
        public override string EndRequestDate { get; set; }
        #endregion Properties
    }
}
