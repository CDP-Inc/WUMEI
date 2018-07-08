using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// The Update Clinic function is an optional function that uses a message based system interface to update,
    /// activate, deactivate or change the status of the clinic record in the WIC EBT System
    /// </summary>
    public class UpdateClinic
    {
        /// <summary>
        /// A constructed data element containing details about the service call and caller.
        /// </summary>
        [Required]
        public MessageHeader MessageHeader { get; set; }

        /// <summary>
        /// A code which defines the action to be taken.
        /// </summary>
        /// <remarks>
        /// Update, Deactivate.
        /// </remarks>
        [Required, StringLength(3, MinimumLength = 3)]
        [RegularExpression(CustomRegex.Num)]
        public string ActionCode { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the Clinic receives mail.
        /// </summary>
        public MailingAddressOp ClinicAddress { get; set; }

        /// <summary>
        /// Business name of the clinic.
        /// </summary>
        [Required, StringLength(50)]
        [RegularExpression(CustomRegex.AbcNumSpecSpace)]
        public string ClinicBusinessName { get; set; }

        /// <summary>
        /// WIC MIS assigned identifier for a clinic.
        /// </summary>
        [Required]
        [Range(typeof(int), "0", "9999999999")]
        public int ClinicId { get; set; }

        /// <summary>
        /// First date on which the clinic is active
        /// expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime BeginClinicDate { get; set; }

        /// <summary>
        /// Last date on which the clinic is active
        /// expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EndClinicDate { get; set; }

        /// <summary>
        /// Date and time when an action is in effect expressed in GMT in accordance with ISO 8601.
        /// </summary>
        /// <remarks>
        /// Required if a specific future date is to be used.
        /// </remarks>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Email address of a point of contact at the Clinic.
        /// </summary>
        [EmailAddress, StringLength(254)]
        [RegularExpression(CustomRegex.AbcNumSpace)]
        public string ClinicContactEmail { get; set; }

        /// <summary>
        /// A constructed data element including the sub-elements first name, middle initial, last name and suffix.
        /// </summary>
        public ContactName ClinicContactName { get; set; }

        /// <summary>
        /// The times of day when entity is available.
        /// </summary>
        [StringLength(12, MinimumLength = 12)]
        [RegularExpression(CustomRegex.Num)]
        public string OperationHours { get; set; }

        /// <summary>
        /// Phone number for the clinic.
        /// </summary>
        [StringLength(10)]
        [RegularExpression(CustomRegex.Num)]
        public string ClinicContactPhoneNumber { get; set; }

        /// <summary>
        /// Reason for an action.
        /// </summary>
        /// <remarks>
        /// Relocated, closed.
        /// </remarks>
        [Required, StringLength(4, MinimumLength = 4)]
        [RegularExpression(CustomRegex.AbcNum)]
        public string ReasonCode { get; set; }
    }
}