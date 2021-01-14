using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Validation attribute that validates that the value entered is a valid type code for a cardholder.
    /// </summary>
    [AttributeUsage(
    AttributeTargets.Field
    | AttributeTargets.Property
    | AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class DateTimeValidationAttribute : ValidationAttribute
    {
        #region Private Fields

        /// <summary>
        /// Gets or sets if the DateTime is required.
        /// </summary>
        public bool Required { get;}

        #endregion

        #region Base Methods

        /// <summary>
        /// Constructs a new DateTime validation attribute.
        /// </summary>
        /// <param name="required">
        /// Flag indicating if the DateTime is required.
        /// </param>
        public DateTimeValidationAttribute(bool required = true)
        {
            Required = required;
        }

        #endregion

        /// <summary>
        /// A method that validates the object.
        /// </summary>
        /// <param name="value">
        /// The value to validate.
        /// </param>
        /// <returns>
        /// A boolean value indicating if the object is valid or not.
        /// </returns>
        public override bool IsValid(object value)
        {
            bool returnValue = false;

            if ((value != null) && !string.IsNullOrEmpty(value.ToString()))
            {
                if (DateTime.TryParse(value.ToString(), out DateTime date))
                {
                    returnValue = true;
                }
            }
            else if (value == null && !Required)
            {
                returnValue = true;
            }

            return returnValue;
        }
    }
}
