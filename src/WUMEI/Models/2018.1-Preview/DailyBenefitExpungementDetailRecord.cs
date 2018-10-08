using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models._2018._1_Preview
{
    public class DailyBenefitExpungementDetailRecord
    {
        /// <summary>
        ///   Gets or sets the quantity of an item defined in the specified benefit issuance unit of measure
        /// </summary>
        /// <remarks>
        ///   This is a required field and accepts values in the range 0.00 and 999.99 (decimal (3,2))
        /// </remarks>
        public decimal BenefitQuantity { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the national UPC database.
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a description of the category code as specified by the originating WIC authority suitable
        /// for printing or displaying in areas where display width is not a concern.
        /// </summary>
        public string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a category code
        /// as defined in the national UPC database.
        /// </summary>
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a long description of the subcategory code suitable for printing or displaying
        /// in areas where display width is not a concern.
        /// </summary>
        public string SubcategoryLongDescription { get; set; }
    }
}
