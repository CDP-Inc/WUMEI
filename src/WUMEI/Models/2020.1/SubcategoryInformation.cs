namespace WUMEI.Models.V2020
{
    /// <summary>
    /// A class which contains results from GetSubcategoryInformation method
    /// </summary>
    public class SubcategoryInformation
    {
        /// <summary>
        /// Gets or sets the benefit unit description.
        /// </summary>
        public string BenefitUnitDescription { get; set; }

        /// <summary>
        /// Gets or sets the category code.
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the subcategory begin date.
        /// </summary>
        public string SubcategoryBeginDate { get; set; }

        /// <summary>
        /// Gets or sets the subcategory end date.
        /// </summary>
        public string SubcategoryEndDate { get; set; }

        /// <summary>
        /// Gets or sets the subcategory code.
        /// </summary>
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the subcategory long description.
        /// </summary>
        public string SubcategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets the subcategory short description.
        /// </summary>
        public string SubcategoryShortDescription { get; set; }
    }
}
