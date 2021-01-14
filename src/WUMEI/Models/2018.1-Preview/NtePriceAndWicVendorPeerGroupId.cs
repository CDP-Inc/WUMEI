using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Data element containing elements that are repeated for each UPC/PLU data data element where there is
    /// more than one WIC Vendor peer group ID and NTE price associated with the UPC/PLU data.
    /// </summary>
    public class NtePriceAndWicVendorPeerGroupId
    {
        /// <summary>
        /// Gets or sets the maximum allowed price for a food item as established by the WIC State Agency.
        /// </summary>
        /// <remarks>
        /// Required when data initially provided.
        /// </remarks>
        [Range(typeof(decimal), "0.0", "9999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal NtePrice { get; set; }

        /// <summary>
        /// Gets or sets an identifier assigned to a set of vendors defined by the
        /// WIC State Agency for managing cost containment.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "99999")]
        public int WicVendorPeerGroupId { get; set; }
    }
}