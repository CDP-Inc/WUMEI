using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Collection of Detail Records for the Add Update Wic Vendor Batch method.
    /// </summary>
    public class WicVendorFileRecord
    {
        /// <summary>
        /// Gets or sets an object identifying a record and carrying metadata about it.
        /// </summary>
        [Required]
        public BatchRecordHeader RecordHeader { get; set; }

        /// <summary>
        /// Gets or sets the number that identifies the financial institution to which a WIC Vendor is paid
        /// via ACH and conforms to the American Bankers Association standard.
        /// </summary>
        [StringLength(9, MinimumLength = 9)]
        [RegularExpression(CustomRegex.Num)]
        public string AbaRoutingTransitNumber { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether or not the volume of WIC sales is above 50% of the
        /// total sales for the WIC Vendor where Y = is above and N = is not above volume.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        [RegularExpression(CustomRegex.YesNoFlag)]
        public string AboveFiftyPercentVendor { get; set; }

        /// <summary>
        /// Gets or sets the ACH cutoff time set by the WIC EBT processor for the WIC Vendor
        /// </summary>
        [RegularExpression(CustomRegex.StandardTime)]
        public string AchSettlementTime { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        [Required]
        [Range(typeof(short), "2", "2")]
        public short ActionCode { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the Wic Vendor receives mail.
        /// </summary>
        [Required]
        public VendorMailingAddress WicVendorMailingAddress { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including Address line 1, Address line 2, Address City,
        /// Address state and Address ZIP code where the WIC Vendor is physically located.
        /// </summary>
        [Required]
        public VendorPhysicalAddress WicVendorPhysicalAddress { get; set; }

        /// <summary>
        /// Gets or sets the volume of total food sales reported by the WIC Vendor.
        /// </summary>
        [Range(typeof(decimal), "0.0", "9999999999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal TotalFoodSalesAmount { get; set; }

        /// <summary>
        /// Gets or sets a value that identifies the type of APL That is assigned to a vendor
        /// and contains only products that
        /// are assigned to the APL type.
        /// </summary>
        [Range(typeof(short), "0", "9999")]
        public short AplType { get; set; }

        /// <summary>
        /// Gets or sets the number identifying the WIC Vendor's bank checking account.
        /// </summary>
        [Range(typeof(long), "0", "99999999999999999")]
        public long BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public virtual string BankName { get; set; }

        /// <summary>
        /// Gets or sets business name of the WIC Vendor.
        /// </summary>
        [Required]
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string WicVendorBusinessName { get; set; }

        /// <summary>
        /// Gets or sets a unique number assigned to a corporation to which WIC Vendors may be associated.
        /// </summary>
        [Range(typeof(long), "0", "999999999999")]
        public long CorporationId { get; set; }

        /// <summary>
        /// Gets or sets the first date the vendor is active and may accept transactions expressed
        /// in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// First date the Vendor is active and accepting WIC.
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string BeginVendorDate { get; set; }

        /// <summary>
        /// Gets or sets date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// The date on which the action is to be effective.
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public virtual string EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets the last date the vendor shall accept WIC expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        [RegularExpression(CustomRegex.StandardDate)]
        public string EndVendorDate { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether a WIC Auto-reconcilliation file is generated
        /// for the WIC Vendor location.
        /// </summary>
        [StringLength(1)]
        [RegularExpression(CustomRegex.YesNoFlag)]
        public string DirectConnectAutoReconFlag { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if the WIC Vendor connects directly to the WIC EBT System.
        /// </summary>
        [StringLength(1)]
        [RegularExpression(CustomRegex.YesNoFlag)]
        public string DirectConnectFlag { get; set; }

        /// <summary>
        /// Gets or sets email address of a point of contact at the WIC Vendor location.
        /// </summary>
        [EmailAddress]
        [StringLength(254)]
        [RegularExpression(CustomRegex.Email)]
        public virtual string WicVendorContactEmail { get; set; }

        /// <summary>
        /// Gets or sets number assigned by the Supplemental Nutrition Assistance Program (SNAP) to a retail location.
        /// </summary>
        [Range(typeof(long), "0", "99999999999")]
        public long FnsNumber { get; set; }

        /// <summary>
        /// Gets or sets WIC MIS assigned identifier that uniquely identifies a local agency within the WIC State Agency.
        /// </summary>
        /// <remarks>
        /// Agency contracting with WIC Vendor.
        /// </remarks>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string LocalAgencyId { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name, middle initial,
        /// last name and suffix.
        /// </summary>
        [Required]
        public ContactName WicVendorContactName { get; set; }

        /// <summary>
        /// Gets or sets an alternate phone number of a point of contact at the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [Range(typeof(long), "0", "9999999999")]
        public long AlternateWicVendorContactPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the phone number for a point of contact at the WIC Vendor.
        /// </summary>
        [Required]
        [Range(typeof(long), "0", "9999999999")]
        public long WicVendorContactPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the reason for an action.
        /// </summary>
        /// <remarks>
        /// Default is "V006 - Vendor eligible to be paid".
        /// </remarks>
        [Required]
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// WIC Vendor type (Chain, Independent grocer, etc).
        /// </remarks>
        [Required]
        [StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public virtual string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets a value assigned by the WIC Management Information System to idenfity the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required]
        [StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }

        /// <summary>
        /// Gets or sets an identifier assigned to a set of vendors defined by the
        /// WIC State Agency for managing cost containment.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "99999")]
        public int WicVendorPeerGroupId { get; set; }

        /// <summary>
        /// Gets or sets a value identifying the federal and/or state tax identification number assigned to the WIC Vendor.
        /// </summary>
        [Range(typeof(int), "0", "999999999")]
        public int WicVendorTaxId { get; set; }
    }
}