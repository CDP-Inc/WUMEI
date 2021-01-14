using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Data element that is repeated for each food item in the purchase.
    /// </summary>
    [XmlRoot(ElementName = "FoodItem")]
    public class GetBenefitRedemptionHistoryResultFoodItem
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GetBenefitRedemptionHistoryResultFoodItem()
        {
            UpcPluData = new UpcPluObject();
        }

        /// <summary>
        /// Gets or sets the amount deducted from the Item price for an individual food item;
        /// not available in X9.93.
        /// </summary>
        [Range(typeof(decimal), "0.0", "9999999999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal ItemDiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount of the adjustment applied to the price of a food item due to the original item
        /// price being in excess of the not to exceed amount for the peer group of the vendor.
        /// </summary>
        [Range(typeof(decimal), "0.0", "9999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal NteAdjustmentAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount of the adjustment applied to the price of a food item due to recoupment owed by the
        /// vendor.
        /// </summary>
        [Range(typeof(decimal), "0.0", "9999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal RecoupmentAdjustmentAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount paid to a WIC Vendor for a purchase transaction less any discounts or adjustments.
        /// The Amount, paid at the transaction level shall equal the sum of the Amount, paid of all of the reported
        /// line items less the Amount, discount at the transaction level. The Amount, paid for an individual line
        /// item is equal to the Original item price as adjusted for Amount, NTE Adjustment and Amount, recoupment
        /// adjustment times the approved Purchase quantity; cannot be less than zero.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "9999999999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal PaidAmount { get; set; }

        /// <summary>
        /// Gets or sets a unique number identifying a benefit issuance;
        /// Assigned by the WIC MIS system.
        /// </summary>
        /// <remarks>
        /// Original value from the benefits issued at the WIC MIS account ID level.
        /// </remarks>
        [Required]
        [Range(typeof(long), "0", "999999999999")]
        public long? BenefitIssuanceId { get; set; }

        /// <summary>
        /// Gets or sets the text description of the originator's specified benefit issuance unit of measure
        /// e.g. can, pkg, jar
        /// </summary>
        /// <remarks>
        /// Only first 6 characters are significant.
        /// </remarks>
        [Required]
        [StringLength(6)]
        [RegularExpression(CustomRegex.AbcNumSpec)]
        public string BenefitUnitDescription { get; set; }

        /// <summary>
        /// Gets or sets a code identifying the type of product as defined in the National UPC database.
        /// </summary>
        /// <remarks>
        /// Category code of the benefit applied to the food item.
        /// </remarks>
        [Required]
        [StringLength(2, MinimumLength = 2)]
        [RegularExpression(CustomRegex.Num)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a literal describing the Category code as specified by the originating WIC authority suitable
        /// for printing or displaying in areas where display width is not a concern.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string CategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets the WIC MIS assigned identifier for a clinic.
        /// </summary>
        /// <remarks>
        /// Required if the Clinic ID was provided with the original issuance of the benefit that was
        /// redeemed as part of this transaction.
        /// </remarks>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ClinicId { get; set; }

        /// <summary>
        /// Gets or sets the first date on which benefits may be used, expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets the last date on which benefits may be used expressed in GMT in accordance with ISO 8601.
        /// </summary>
        [Required]
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndBenefitDate { get; set; }

        /// <summary>
        /// Gets or sets an identifier assigned to a WIC MIS user that is used to track activity in the system.
        /// </summary>
        /// <remarks>
        /// Required for adjustment transactions if Clinic ID of original transaction being retrieved is present
        /// and was provided with the original issuance of the benefit that was redeemed as part of this transaction.
        /// </remarks>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string InitiatingUserId { get; set; }

        /// <summary>
        /// Gets or sets the code indicating the action taken on an item; corresponds to bit 62-PS-6.
        /// </summary>
        [StringLength(2)]
        [RegularExpression(CustomRegex.Num)]
        public string ItemActionCode { get; set; }

        /// <summary>
        /// Gets or sets the name for a WIC food item.
        /// </summary>
        [Required]
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public virtual string ItemDescription { get; set; }

        /// <summary>
        /// Gets or sets the NTE amount assigned to one unit of a food item for a given peer group and in
        /// effect at the time of the transaction.
        /// </summary>
        [Range(typeof(decimal), "0.0", "9999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal? ItemNte { get; set; }

        /// <summary>
        /// Gets or sets the purchase amount assigned to one unit of a food item.
        /// </summary>
        /// <remarks>
        /// The item price after any adjustments are applied.
        /// </remarks>
        [Required]
        [Range(typeof(decimal), "0.0", "9999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal ItemPrice { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for a line item within a transaction.
        /// </summary>
        /// <remarks>
        /// Required when a single food item requires multiple reporting records to account for applying units across
        /// Sub-categories or Benefit IDs. May be the original Record sequence number for the food item from the
        /// WIC auto-reconciliation addenda record 2 (e2).
        /// </remarks>
        [Range(typeof(int), "0", "999999")]
        public int LineItemId { get; set; }

        /// <summary>
        /// Gets or sets the WIC MIS assigned identifier that uniquely identifies a local agency within the WIC State.
        /// Agency.
        /// </summary>
        /// <remarks>
        /// Required if the Local agency ID was provided with the original issuance
        /// of the benefit that was redeemed as part of this transaction.
        /// </remarks>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string LocalAgencyId { get; set; }

        /// <summary>
        /// Gets or sets the amount requested by a WIC vendor for a purchase transaction for the specific item
        /// purchased. The Original amount is equal to the requested Original item price times the approved Original
        /// purchase quantity and cannot be less than zero.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "9999999999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal OriginalAmount { get; set; }

        /// <summary>
        /// Gets or sets the code identifying the requested type of product as defined in the National UPC database.
        /// </summary>
        /// <remarks>
        /// Category code assigned to the UPC or PLU.
        /// </remarks>
        [Required]
        [StringLength(2, MinimumLength = 2)]
        [RegularExpression(CustomRegex.Num)]
        public string OriginalCategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the original purchase amount for a single food item in the original request.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "9999.99")]
        [RegularExpression(CustomRegex.DecimalNum)]
        public decimal OriginalItemPrice { get; set; }

        /// <summary>
        /// Gets or sets the number of food items or quantity of a food item originally requested in the Unit of measure
        /// associated with the UPC/PLU, also called the exchange size.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        public decimal OriginalPurchaseQuantity { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the requested type of product as defined in the National UPC
        /// database.
        /// </summary>
        /// <remarks>
        /// Sub-Category code of the benefit applied to the food item.
        /// </remarks>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string OriginalSubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets the size of the contents of the package quantified in the standard benefit units of measure.
        /// </summary>
        [Range(typeof(decimal), "0.0", "999.99")]
        public decimal? PackageSize { get; set; }

        /// <summary>
        /// Gets or sets the number of food items or quantity of a food item being purchased in the unit of measure
        /// associated with the UPC/PLU, also called the exchange size.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        public decimal PurchaseQuantity { get; set; }

        /// <summary>
        /// Gets or sets a code further identifying the type of product within a Category code
        /// as defined in the National UPC database.
        /// </summary>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string SubcategoryCode { get; set; }

        /// <summary>
        /// Gets or sets a long description of the Sub-Category code suitable for printing or displaying
        /// in areas where display width is not a concern.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string SubcategoryLongDescription { get; set; }

        /// <summary>
        /// Gets or sets the number of benefit units of an item being reported.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.0", "999.99")]
        public decimal Units { get; set; }

        /// <summary>
        /// Gets or sets an object that represents UPC or PLU data.
        /// </summary>
        [Required]
        public UpcPluObject UpcPluData { get; set; }

        /// <summary>
        /// Gets or sets the number assigned to a paper sales draft issued to the WIC Participant.
        /// </summary>
        [StringLength(15)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string VoucherNumber { get; set; }

        /// <summary>
        /// Gets or sets the value identifying the workstation initiating the function.
        /// </summary>
        /// <remarks>
        /// Required if Clinic ID of original transaction being retrieved is present and was provided with the
        /// original issuance of the benefit that was redeemed as part of this transaction.
        /// </remarks>
        [StringLength(20)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WorkStationId { get; set; }
    }
}
