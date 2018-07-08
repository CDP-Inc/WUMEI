using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Collection of Detail Records for the Add Update WIC Vendor Hierarchy Information Batch method.
    /// </summary>
    public class AddUpdateWicVendorHierarchyInformationBatchDetailRecords
    {
        /// <summary>
        /// The number that identifies the financial institution to which a WIC Vendor is paid
        /// via ACH and conforms to the American Bankers Association standard.
        /// </summary>
        [StringLength(9, MinimumLength = 9)]
        [RegularExpression(CustomRegex.Num)]
        public string AbaRoutingTransitNumber { get; set; }

        /// <summary>
        /// A code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Add or Update.
        /// </remarks>
        [Required, StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the Corporation receives mail.
        /// </summary>
        [Required]
        public MailingAddressRq CorporationMailingAddress { get; set; }

        /// <summary>
        /// The number identifying the WIC Vendor's bank checking account.
        /// </summary>
        /// <remarks>
        /// FNS recommends this data element be encrypted.
        /// </remarks>
        [Range(typeof(long), "0", "99999999999999999")]
        public long BankAccountNumber { get; set; }

        /// <summary>
        /// The business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.AbcSpecSpace)]
        public string BankName { get; set; }

        /// <summary>
        /// Business name of the corporation.
        /// </summary>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string CorporationBusinessName { get; set; }

        /// <summary>
        /// A unique number assigned to a corporation to which WIC Vendors may be associated.
        /// </summary>
        [Required]
        [Range(typeof(long), "0", "999999999999")]
        public long CorporationId { get; set; }

        /// <summary>
        /// Date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Email address of a point of contact at the corporation.
        /// </summary>
        [EmailAddress, StringLength(254)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string CorporationContactEmail { get; set; }

        /// <summary>
        /// A value indicating the position of the WIC Vendor location within the corporation hierarchy.
        /// </summary>
        /// <remarks>
        /// Default is "no hierarchy".
        /// </remarks>
        [Required]
        [Range(typeof(byte), "0", "9")]
        public byte HierarchyCode { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements First name, middle initial, last name and suffix.
        /// </summary>
        [Required]
        public ContactName CorporationContactName { get; set; }

        /// <summary>
        /// An alternate phone number of a point of contact at the Corporation.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string AlternateCorporationContactPhoneNumber { get; set; }

        /// <summary>
        /// Phone number for the clinic.
        /// </summary>
        [Required, StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string CorporationContactPhoneNumber { get; set; }

        /// <summary>
        /// A code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// WIC Vendor type (Chain, Independent grocer, etc).
        /// </remarks>
        [Required, StringLength(1)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string TypeCode { get; set; }
    }
}