namespace WUMEI.Models._2018._1_Preview
{
    /// <summary>
    /// Category Details
    /// </summary>
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
        public byte CategoryCode { get; set; }

        /// <summary>
        ///   Category Long Description code of the redeemed benefit.
        /// </summary>
        public string CategoryLongDescription { get; set; }

        /// <summary>
        ///   Subcategory code of the assigned benefit
        /// </summary>
        public short SubcategoryCode { get; set; }

        /// <summary>
        ///   SubcategoryLongDescription code of the assigned benefit
        /// </summary>
        public string SubcategoryLongDescription { get; set; }
    }
}
