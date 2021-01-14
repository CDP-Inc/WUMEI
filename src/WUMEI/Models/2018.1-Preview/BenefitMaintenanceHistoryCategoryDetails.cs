namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Category Details
    /// </summary>
    public class BenefitMaintenanceHistoryCategoryDetails
    {
        /// <summary>
        /// Gets or sets the quantity of an item defined in the sender’s specified benefit issuance Unit of measure
        /// </summary>
        /// <remarks>
        /// This is a required field and accepts values in the range 0.00 and 999.99 (decimal (3,2))
        /// </remarks>
        public decimal BenefitQuantity { get; set; }

        /// <summary>
        /// Gets or sets the category code of the redeemed benefit.
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the category Long Description code of the redeemed benefit.
        /// </summary>
        public string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets the subcategory code of the assigned benefit
        /// </summary>
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the subcategoryLongDescription code of the assigned benefit
        /// </summary>
        public string SubcategoryLongDescription { get; set; }
    }
}
