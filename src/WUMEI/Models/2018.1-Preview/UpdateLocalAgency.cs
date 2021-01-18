using System;
using System.ComponentModel.DataAnnotations;
namespace WUMEI.Models.V2018
{
    /// <summary>
    /// The Update Local Agency function is an optional function that uses a message based system interface to
    /// update the local agency information record in the WIC EBT System, including activating and deactivating
    /// the local agency.
    /// </summary>
    public class UpdateLocalAgency
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Update or Deactivate.
        /// </remarks>
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }
        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the Local Agency receives mail.
        /// </summary>
        public MailingAddress LocalAgencyAddress { get; set; }

        /// <summary>
        /// Gets or sets business name of the local agency.
        /// </summary>
        [StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string LocalAgencyBusinessName { get; set; }

        /// <summary>
        /// Gets or sets first date on which the Local Agency is active expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime BeginLocalAgencyDate { get; set; }

        /// <summary>
        /// Gets or sets last date on which the Local Agency is active expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EndLocalAgencyDate { get; set; }

        /// <summary>
        /// Gets or sets date and time when an action is in effect expressed in GMT in accordance with ISO 8601
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public virtual DateTime DateEffective { get; set; }

        /// <summary>
        /// Gets or sets email address of a point of contact at the local agency.
        /// </summary>
        [EmailAddress, StringLength(254)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string LocalAgencyContactEmail { get; set; }

        /// <summary>
        /// Gets or sets WIC MIS assigned identifier that uniquely identifies a local agency within
        /// the WIC State Agency.
        /// </summary>
        [Required, StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string LocalAgencyId { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element containing First name, middle initial, last name and suffix.
        /// </summary>
        public ContactName LocalAgencyContact { get; set; }

        /// <summary>
        /// Gets or sets the times of day when entity is available.
        /// </summary>
        [StringLength(12, MinimumLength = 12)]
        [RegularExpression(CustomRegex.Num)]
        public string OperationHours { get; set; }

        /// <summary>
        /// Gets or sets phone number for the local agency.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string LocalAgencyContactPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets reason for an action.
        /// </summary>
        /// <remarks>
        /// Relocated, closed.
        /// </remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }
    }
}