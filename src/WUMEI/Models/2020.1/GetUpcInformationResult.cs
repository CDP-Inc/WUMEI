using System.Collections.Generic;
using WUMEI.Models.V2018;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Objects of this class will hold the results of GetUpcInformation method
    /// </summary>
    public class GetUpcInformationResult
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets the allocated benefit quantity of the UPC/PLU
        /// </summary>
        public decimal BenefitQuantity { get; set; }

        /// <summary>
        /// Gets or sets a text description of the originator's specified benefit issuance unit of measure
        /// e.g. can, pkg, jar
        /// </summary>
        public string BenefitUnitDescription { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the national UPC database.
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
        /// Gets or sets the subcategory begin date.
        /// </summary>
        public string SubcategoryBeginDate { get; set; }

        /// <summary>
        /// Gets or sets the date for which the UPC/PLU shall become available for use expressed
        /// in GMT in accordance with ISO 8601.
        /// </summary>
        public string UpcBeginDate { get; set; }

        /// <summary>
        /// Gets or sets the category's end date.
        /// </summary>
        public string CategoryEndDate { get; set; }

        /// <summary>
        /// Gets or sets the subcategory end date.
        /// </summary>
        public string SubcategoryEndDate { get; set; }

        /// <summary>
        /// Gets or sets the last date for which the UPC/PLU shall be used expressed in GMT in
        /// accordance with ISO 8601.
        /// </summary>
        public string UpcEndDate { get; set;  }

        /// <summary>
        /// Gets or sets a description of the item with UPC/PLU code suitable for printing or displaying
        /// in areas where display width is not a concern.
        /// </summary>
        public string ItemDescription { get; set; }

        /// <summary>
        /// Gets or sets a flag to indicate if a food item is allowed for purchase with a manual
        /// voucher.
        /// Returned as null for 2020.1 GetUpcInformation
        /// </summary>
        public string ManualVoucherIndicator { get; set; }

        /// <summary>
        /// Gets or sets a code to identify the level used for calculation of NTE where S = sub-category
        /// and U = UPC.
        /// Returned as null for 2020.1 GetUpcInformation
        /// </summary>
        public string NTECalculationIndicator { get; set; }

        /// <summary>
        /// Gets or sets the size of the contents of the package quantified in the standard benefit
        /// units of measure.
        /// </summary>
        public decimal PackageSize { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a category code
        /// as defined in the national UPC database.
        /// </summary>
        public string PriceType { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a category code
        /// as defined in the national UPC database.
        /// </summary>
        public short PurchaseIndicator { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a category code
        /// as defined in the national UPC database.
        /// </summary>
        public short RebateFlag { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a category code
        /// as defined in the national UPC database.
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

        /// <summary>
        /// Gets or sets the Object which provides information identifying the UPC or PLU
        /// assigned to a food item.
        /// </summary>
        public UpcPluObject UpcPluData { get; set; }

        /// <summary>
        /// Gets or sets the Object which provides information for NTE (Not to exceed) Price Data.
        /// assigned to a food item.
        /// </summary>
        public List<V2018.NtePriceAndWicVendorPeerGroupId> NteData { get; set; }
    }
}
