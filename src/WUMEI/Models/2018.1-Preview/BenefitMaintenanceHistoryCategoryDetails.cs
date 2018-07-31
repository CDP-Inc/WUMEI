using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models._2018._1_Preview
{
    public class BenefitMaintenanceHistoryCategoryDetails
    {
        /// <summary>
        ///   The quantity of an item defined in the sender’s specified benefit issuance Unit of measure
        /// </summary>
        /// <remarks>
        ///   This is a required field and accepts values in the range 0.00 and 999.99 (decimal (3,2))
        /// </remarks>
        public decimal BenefitQuantity { get; set; }

        /// <summary>
        ///   Category code of the redeemed benefit.
        /// </summary>
        public int CategoryCode { get; set; }

        /// <summary>
        ///   Category Long Description code of the redeemed benefit.
        /// </summary>
        public string CategoryLongDescription { get; set; }

        /// <summary>
        ///   Subcategory code of the assigned benefit
        /// </summary>
        public int SubcategoryCode { get; set; }

        /// <summary>
        ///   SubcategoryLongDescription code of the assigned benefit
        /// </summary>
        public string SubcategoryLongDescription { get; set; }
    }
}
