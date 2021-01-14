namespace WUMEI.Models.V2020
{
    /// <summary>
    /// A class which contains results from GetCategoryInformation method
    /// </summary>
    public class CategoryInformation
    {
        /// <summary>
        /// Gets or sets the category code.
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the category's long description.
        /// </summary>
        public string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets the category's short description.
        /// </summary>
        public string CategoryShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the category's begin date.
        /// </summary>
        public string CategoryBeginDate { get; set; }

        /// <summary>
        /// Gets or sets the category's end date.
        /// </summary>
        public string CategoryEndDate { get; set; }
    }
}
