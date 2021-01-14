using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Object that contains all parameters for the Add Update Wic Vendor Hierarchy Information Batch method.
    /// </summary>
    public class AddUpdateWicVendorHierarchyInformation : V2018.AddUpdateWicVendorHierarchyInformation
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public new MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the Corporation receives mail.
        /// </summary>
        [Required]
        public new MailingAddressRq CorporationMailingAddress { get; set; }

        /// <summary>
        /// Gets or sets the business entity holding the bank account of the WIC Vendor.
        /// </summary>
        [JsonIgnore]
        public override string BankName { get; set; }

        /// <summary>
        /// Gets or sets an email address of a point of contact at the corporation.
        /// </summary>
        [EmailAddress, StringLength(254)]
        [RegularExpression(CustomRegex.AenPattern)]
        public override string CorporationContactEmail { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements First name, middle initial, last name and suffix.
        /// </summary>
        [Required]
        public new ContactName CorporationContactName { get; set; }

        /// <summary>
        /// Gets or sets a code indicating the kind of entity being acted or reported upon in the function.
        /// </summary>
        /// <remarks>
        /// WIC Vendor type (Chain, Independent grocer, etc).
        /// </remarks>
        [Required, StringLength(1)]
        [RegularExpression(CustomRegex.Valid2020VendorTypesRegex)]
        public override string TypeCode { get; set; }
    }
}