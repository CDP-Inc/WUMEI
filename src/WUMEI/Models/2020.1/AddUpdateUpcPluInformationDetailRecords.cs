using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Collection of Detail Records for the Add Update UPC PLU Information method.
    /// </summary>
    public class AddUpdateUpcPluInformationDetailRecords : V2018.AddUpdateUpcPluInformationDetailRecords
    {
        /// <summary>
        /// Gets or sets a text description of the originator's specified benefit issuance unit of measure
        /// e.g. can, pkg, jar
        /// </summary>
        /// <remarks>
        /// Only first 6 characters are significant.
        /// </remarks>
        [JsonIgnore]
        public override string BenefitUnitDescription { get; set; }

        /// <summary>
        /// Gets or sets the number of iterations of APL type in the UPC/PLU record.
        /// </summary>
        [JsonIgnore]
        public override short NumberOfAplTypes { get; set; }

        /// <summary>
        /// Gets or sets the number of iterations of WIC Vendor peer groups and NTE prices for those groups.
        /// </summary>
        /// <remarks>
        /// Identifies how many WIC Vendor peer group IDs are included in the repeating section below.
        /// </remarks>
        [JsonIgnore]
        public override byte NumberOfWicVendorPeerGroups { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element containing elements repeated for each UPC/PLU data element where an
        /// NTE price is provided.
        /// </summary>
        [JsonIgnore]
        public override IEnumerable<V2018.NtePriceAndWicVendorPeerGroupId> NtePriceWicVendorPeerGroupId { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element containing elements repeated for each UPC/PLU data element where an
        /// NTE price is provided.
        /// </summary>
        [Required]
        public IEnumerable<V2018.NtePriceAndWicVendorPeerGroupId> NteData { get; set; }
    }
}