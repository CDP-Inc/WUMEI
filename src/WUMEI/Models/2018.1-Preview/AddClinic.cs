using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// The Add Clinic function is an optional function that uses a message based system interface to add a clinic
    /// information record in the WIC EBT System.
    /// </summary>
    public class AddClinic
    {
        /// <summary>
        /// Gets or sets a constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the Clinic receives mail.
        /// </summary>
        [Required]
        public MailingAddress ClinicAddress { get; set; }

        /// <summary>
        /// Gets or sets the business name of the clinic.
        /// </summary>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string ClinicBusinessName { get; set; }

        /// <summary>
        /// Gets or sets the WIC MIS assigned identifier for a clinic.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "9999999999")]
        public int ClinicId { get; set; }

        /// <summary>
        /// Gets or sets the first date on which the clinic is active
        /// expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime BeginClinicDate { get; set; }

        /// <summary>
        /// Gets or sets the last date on which the clinic is active
        /// expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EndClinicDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public virtual DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Gets or sets the email address of a point of contact at the Clinic.
        /// </summary>
        [EmailAddress, StringLength(254)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string ClinicContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the WIC MIS assigned identifier that uniquely identifies a local agency within
        /// the WIC State Agency.
        /// </summary>
        [Required, StringLength(10)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string LocalAgencyId { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name, middle initial,
        /// last name and suffix.
        /// </summary>
        [Required]
        public ContactName ClinicContactName { get; set; }

        /// <summary>
        /// Gets or sets the times of day when entity is available.
        /// </summary>
        [StringLength(12, MinimumLength = 12)]
        [RegularExpression(CustomRegex.Num)]
        public virtual string OperationHours { get; set; }

        /// <summary>
        /// Gets or sets the phone number for the clinic.
        /// </summary>
        [Required, StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string ClinicContactPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the reason for an action.
        /// </summary>
        /// <remarks>
        /// New clinic.
        /// </remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }
    }
}