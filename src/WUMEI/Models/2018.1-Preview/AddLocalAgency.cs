using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// The Add Local Agency function is an optional function that uses a message based system interface to
    /// create a local agency information record in the WIC EBT System.
    /// </summary>
    public class AddLocalAgency
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the Local Agency receives mail.
        /// </summary>
        [Required]
        public MailingAddressRq LocalAgencyAddress { get; set; }

        /// <summary>
        /// Business name of the local agency.
        /// </summary>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string LocalAgencyBusinessName { get; set; }

        /// <summary>
        /// First date on which the Local Agency is active expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime BeginLocalAgencyDate { get; set; }

        /// <summary>
        /// Last date on which the Local Agency is active expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EndLocalAgencyDate { get; set; }

        /// <summary>
        /// Date and time when an action is in effect expressed in GMT in accordance with ISO 8601
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime DateEffective { get; set; }

        /// <summary>
        /// Email address of a point of contact at the Local Agency.
        /// </summary>
        [EmailAddress, StringLength(254)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string LocalAgencyContactEmail { get; set; }

        /// <summary>
        /// WIC MIS assigned identifier that uniquely identifies a local agency within the WIC State Agency.
        /// </summary>
        [Required, StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string LocalAgencyId { get; set; }

        /// <summary>
        /// A constructed data element containing First name, middle initial, last name and suffix.
        /// </summary>
        [Required]
        public ContactName LocalAgencyContact { get; set; }

        /// <summary>
        /// The times of day when entity is available.
        /// </summary>
        [StringLength(12, MinimumLength = 12)]
        [RegularExpression(CustomRegex.Num)]
        public string OperationHours { get; set; }

        /// <summary>
        /// Phone number for the local agency.
        /// </summary>
        [Required, StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string LocalAgencyContactPhoneNumber { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        /// <remarks>
        /// Default is "New."
        /// </remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }
    }
}