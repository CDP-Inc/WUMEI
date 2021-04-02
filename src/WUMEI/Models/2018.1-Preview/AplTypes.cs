using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Contains the APL type data element that is repeated for each UPC/PLU Data element.
    /// </summary>
    public class AplTypes
    {
        /// <summary>
        /// Gets or sets the type of APL That is assigned to a vendor and contains only products that
        /// are assigned to the APL type.
        /// </summary>
        [Range(typeof(short), "0", "9999")]
        public short AplType { get; set; }
    }
}