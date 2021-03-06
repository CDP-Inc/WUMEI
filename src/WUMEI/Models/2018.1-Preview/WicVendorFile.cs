﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Object that contains all parameters required for the Add Update WIC Vendor Batch method.
    /// </summary>
    public class WicVendorFile
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public BatchHeader Header { get; set; }

        /// <summary>
        /// Gets or sets a collection of Detail Records for the Add Update WIC Vendor Batch method.
        /// </summary>
        public IEnumerable<WicVendorFileRecord> Records { get; set; }
    }
}