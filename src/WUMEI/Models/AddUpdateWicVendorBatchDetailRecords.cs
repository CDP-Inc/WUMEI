using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Collection of Detail Records for the Add Update Wic Vendor Batch method.
    /// </summary>
    public class AddUpdateWicVendorBatchDetailRecords
    {
        /// <summary>
        /// The number that identifies the financial institution to which a WIC Vendor is paid
        /// via ACH and conforms to the American Bankers Association standard.
        /// </summary>
        [StringLength(9, MinimumLength = 9)]
        [RegularExpression(CustomRegex.Num)]
        public string AbaRoutingTransitNumber { get; set; }

        /// <summary>
        /// A flag indicating whether or not the volume of WIC sales is above 50% of the
        /// total sales for the WIC Vendor where Y = is above and N = is not above volume.
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string AboveFiftyPercentVendor { get; set; }

        /// <summary>
        /// The ACH cutoff time set by the WIC EBT processor for the WIC Vendor
        /// </summary>
        public DateTime AchSettlementTime { get; set; }

        /// <summary>
        /// A code which defines the action to be taken.
        /// </summary>
        [Required, StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements Address line 1, Address line 2, 
        /// Address city, Address state and Address ZIP code where the Wic Vendor receives mail. 
        /// </summary>
        [Required]
        public MailingAddressRq WicVendorMailingAddress { get; set; }

        /// <summary>
        /// A constructed data element including Address line 1, Address line 2, Address City,
        /// Address state and Address ZIP code where the WIC Vendor is physically located.
        /// </summary>
        [Required]
        public MailingAddressRq WicVendorPhysicalAddress { get; set; }

        /// <summary>
        /// The volume of total food sales reported by the WIC Vendor.
        /// </summary>
        [Range(typeof(decimal), "0.0", "9999999999.99")]
        [RegularExpression(CustomRegex.Price)]
        public decimal TotalFoodSalesAmount { get; set; }

        /// <summary>
        /// Identifies the type of APL That is assigned to a vendor and contains only products that
        /// are assigned to the APL type.
        /// </summary>
        [Range(typeof(short), "0", "9999")]
        public short AplType { get; set; }

        /// <summary>
        /// The number identifying the WIC Vendor's bank checking account.
        /// </summary>
        [Range(typeof(long), "0", "99999999999999999")]
        public long BankAccountNumber { get; set; }

        /// <summary>
        /// The business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcSpecSpace)]
        public string BankName { get; set; }

        /// <summary>
        /// Business name of the WIC Vendor.
        /// </summary>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string WicVendorBusinessName { get; set; }

        /// <summary>
        /// A unique number assigned to a corporation to which WIC Vendors may be associated.
        /// </summary>
        [Range(typeof(long), "0", "999999999999")]
        public long CorporationId { get; set; }

        /// <summary>
        /// The first date the vendor is active and may accept transactions expressed
        /// in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// First date the Vendor is active and accepting WIC.
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime BeginVendorDate { get; set; }

        /// <summary>
        /// Date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// The date on which the action is to be effective.
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// The last date the vendor shall accept WIC expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EndVendorDate { get; set; }

        /// <summary>
        /// A flag indicating whether a WIC Auto-reconcilliation file is generated
        /// for the WIC Vendor location.
        /// </summary>
        [StringLength(1)]
        [RegularExpression(CustomRegex.Abc)]
        public string DirectConnectAutoReconFlag { get; set; }

        /// <summary>
        /// A flag indicating if the WIC Vendor connects directly to the WIC EBT System.
        /// </summary>
        [StringLength(1)]
        [RegularExpression(CustomRegex.Abc)]
        public string DirectConnectFlag { get; set; }

        /// <summary>
        /// Email address of a point of contact at the WIC Vendor location.
        /// </summary>
        [EmailAddress, StringLength(254)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string WicVendorContactEmail { get; set; }

        /// <summary>
        /// Number assigned by the Supplemental Nutrition Assistance Program (SNAP) to a retail location.
        /// </summary>
        [Range(typeof(long), "0", "99999999999")]
        public long FnsNumber { get; set; }

        /// <summary>
        /// WIC MIS assigned identifier that uniquely identifies a local agency within the WIC State Agency.
        /// </summary>
        /// <remarks>
        /// Agency contracting with WIC Vendor.
        /// </remarks>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string LocalAgencyId { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements first name, middle initial, last name and suffix.
        /// </summary>
        [Required]
        public ContactNameRq WicVendorContactName { get; set; }

        /// <summary>
        /// An alternate phone number of a point of contact at the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string AlternateWicVendorContactPhoneNumber { get; set; }

        /// <summary>
        /// The phone number for a point of contact at the WIC Vendor.
        /// </summary>
        [Required, StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string WicVendorContactPhoneNumber { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        /// <remarks>
        /// Default is "V006 - Vendor eligible to be paid".
        /// </remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// WIC Vendor type (Chain, Independent grocer, etc).
        /// </remarks>
        [Required, StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Value assigned by the WIC Management Information System to idenfity the WIC Vendor
        /// equal to WIC merchant ID from X9.93.
        /// </summary>
        [Required, StringLength(12)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string WicMisWicVendorId { get; set; }

        /// <summary>
        /// An identifier assigned to a set of vendors defined by the
        /// WIC State Agency for managing cost containment.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "99999")]
        public int WicVendorPeerGroupId { get; set; }

        /// <summary>
        /// A value identifying the federal and/or state tax identification number assigned to the WIC Vendor.
        /// </summary>
        [StringLength(9)]
        [Range(typeof(int), "0", "999999999")]
        public int WicVendorTaxId { get; set; }
    }
}