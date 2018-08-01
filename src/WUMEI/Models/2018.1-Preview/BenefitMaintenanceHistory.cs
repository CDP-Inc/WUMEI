using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WUMEI.Models._2018._1_Preview;

namespace WUMEI.Models
{
    /// <summary>
    /// Object that contains all parameters returned for the Get Benefit Maintenance History method.
    /// </summary>
    public class BenefitMaintenanceHistory
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        public List<BenefitMaintenanceHistoryDetails> BenefitHistoryDetails { get; set; }
    }
}