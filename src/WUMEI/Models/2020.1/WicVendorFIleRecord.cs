using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using WUMEI.Models.V2018;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Collection of Detail Records for the Add Update Wic Vendor Batch method.
    /// </summary>
    public class WicVendorFileRecord : V2018.WicVendorFileRecord
    {
        /// <summary>
        /// Gets or sets the number identifying the WIC Vendor's bank checking account.
        /// </summary>
        [Range(1, 99999999999999999)]
        public new long? BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [JsonIgnore]
        public override string BankName { get; set; }

        /// <summary>
        /// Gets or sets date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// The date on which the action is to be effective.
        /// Required if a specific future date is to be used.
        /// </remarks>
        [JsonIgnore]
        public override string EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets a number assigned by the Supplemental Nutrition Assistance Program (SNAP) to a retail location.
        /// </summary>
        [StringLength(7)]
        [RegularExpression(CustomRegex.Num)]
        public new string FnsNumber { get; set; }

        /// <inheritdoc />
        [EmailAddress]
        [StringLength(254)]
        [RegularExpression(CustomRegex.AenPattern)]
        public override string WicVendorContactEmail { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name, middle initial,
        /// last name and suffix.
        /// </summary>
        [Required]
        public new VendorContactName WicVendorContactName { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the WIC Vendor receives mail.
        /// </summary>
        [Required]
        public new VendorMailingAddress WicVendorMailingAddress { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including Address line 1, Address line 2, Address City,
        /// Address state and Address ZIP code where the WIC Vendor is physically located.
        /// </summary>
        [Required]
        public new VendorPhysicalAddress WicVendorPhysicalAddress { get; set; }

        /// <summary>
        /// Gets or sets code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// WIC Vendor type (Chain, Independent grocer, etc).
        /// </remarks>
        [Required]
        [StringLength(1)]
        [RegularExpression(CustomRegex.Valid2020VendorTypesRegex)]
        public override string TypeCode { get; set; }
    }
}