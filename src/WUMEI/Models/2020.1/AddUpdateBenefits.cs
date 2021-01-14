using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters required for the Add Update Benefits method.
    /// </summary>
    public class AddUpdateBenefits : V2018.AddUpdateBenefits
    {
        #region Properties

        /// <summary>
        /// Gets or sets constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets element that is repeated for each Benefit issuance ID.
        /// </summary>
        [Required]
        [NumItems(Min = 1)]
        public new IEnumerable<AddUpdateBenefitsBenefitBalance> BenefitBalance { get; set; }

        #endregion Properties
    }
}
