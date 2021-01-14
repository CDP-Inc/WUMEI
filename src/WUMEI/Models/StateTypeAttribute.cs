using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Validation attribute that validates that the value entered is a valid US state/territory or state
    /// abbreviation.
    /// </summary>
    [AttributeUsage(
    AttributeTargets.Field
    | AttributeTargets.Property
    | AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class StateTypeAttribute : ValidationAttribute
    {
        private Dictionary<string, string> statesAndTerritoriesDictionary;

        /// <summary>
        /// Constructor
        /// </summary>
        public StateTypeAttribute()
        {
            statesAndTerritoriesDictionary = new Dictionary<string, string>();

            BuildStateDictionary();
        }

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
            string state = value == null ? string.Empty : value.ToString() ;

            bool returnValue = false;

            if (!string.IsNullOrEmpty(state))
            {
                // Check to see if the value being validated is a name or an abbreviation
                returnValue = statesAndTerritoriesDictionary.ContainsValue(state) ||
                               statesAndTerritoriesDictionary.ContainsKey(state);
            }

            return returnValue;
        }

        /// <summary>
        /// A method that builds a dictionary of all the states and their abbreviations.
        /// </summary>
        private void BuildStateDictionary()
        {
            // Add all the states and territories into the dictionary
            statesAndTerritoriesDictionary.Add("Alabama", "AL");
            statesAndTerritoriesDictionary.Add("Alaska", "AK");
            statesAndTerritoriesDictionary.Add("Arizona", "AZ");
            statesAndTerritoriesDictionary.Add("Arkansas", "AR");
            statesAndTerritoriesDictionary.Add("California", "CA");
            statesAndTerritoriesDictionary.Add("Colorado", "CO");
            statesAndTerritoriesDictionary.Add("Connecticut", "CT");
            statesAndTerritoriesDictionary.Add("Delaware", "DE");
            statesAndTerritoriesDictionary.Add("District of Columbia", "DC");
            statesAndTerritoriesDictionary.Add("Florida", "FL");
            statesAndTerritoriesDictionary.Add("Georgia", "GA");
            statesAndTerritoriesDictionary.Add("Hawaii", "HI");
            statesAndTerritoriesDictionary.Add("Idaho", "ID");
            statesAndTerritoriesDictionary.Add("Illinois", "IL");
            statesAndTerritoriesDictionary.Add("Indiana", "IN");
            statesAndTerritoriesDictionary.Add("Iowa", "IA");
            statesAndTerritoriesDictionary.Add("Kansas", "KS");
            statesAndTerritoriesDictionary.Add("Kentucky", "KY");
            statesAndTerritoriesDictionary.Add("Louisiana", "LA");
            statesAndTerritoriesDictionary.Add("Maine", "ME");
            statesAndTerritoriesDictionary.Add("Maryland", "MD");
            statesAndTerritoriesDictionary.Add("Massachusetts", "MA");
            statesAndTerritoriesDictionary.Add("Michigan", "MI");
            statesAndTerritoriesDictionary.Add("Minnesota", "MN");
            statesAndTerritoriesDictionary.Add("Mississippi", "MS");
            statesAndTerritoriesDictionary.Add("Missouri", "MO");
            statesAndTerritoriesDictionary.Add("Montana", "MT");
            statesAndTerritoriesDictionary.Add("Nebraska", "NE");
            statesAndTerritoriesDictionary.Add("Nevada", "NV");
            statesAndTerritoriesDictionary.Add("New Hampshire", "NH");
            statesAndTerritoriesDictionary.Add("New Jersey", "NJ");
            statesAndTerritoriesDictionary.Add("New Mexico", "NM");
            statesAndTerritoriesDictionary.Add("New York", "NY");
            statesAndTerritoriesDictionary.Add("North Carolina", "NC");
            statesAndTerritoriesDictionary.Add("North Dakota", "ND");
            statesAndTerritoriesDictionary.Add("Ohio", "OH");
            statesAndTerritoriesDictionary.Add("Oklahoma", "OK");
            statesAndTerritoriesDictionary.Add("Oregon", "OR");
            statesAndTerritoriesDictionary.Add("Pennsylvania", "PA");
            statesAndTerritoriesDictionary.Add("Rhode Island", "RI");
            statesAndTerritoriesDictionary.Add("South Carolina", "SC");
            statesAndTerritoriesDictionary.Add("South Dakota", "SD");
            statesAndTerritoriesDictionary.Add("Tennessee", "TN");
            statesAndTerritoriesDictionary.Add("Texas", "TX");
            statesAndTerritoriesDictionary.Add("Utah", "UT");
            statesAndTerritoriesDictionary.Add("Vermont", "VT");
            statesAndTerritoriesDictionary.Add("Virginia", "VA");
            statesAndTerritoriesDictionary.Add("Washington", "WA");
            statesAndTerritoriesDictionary.Add("West Virginia", "WV");
            statesAndTerritoriesDictionary.Add("Wisconsin", "WI");
            statesAndTerritoriesDictionary.Add("Wyoming", "WY");
            statesAndTerritoriesDictionary.Add("American Samoa", "AS");
            statesAndTerritoriesDictionary.Add("Guam", "AP");
            statesAndTerritoriesDictionary.Add("Northern Mariana Islands", "MP");
            statesAndTerritoriesDictionary.Add("Puerto Rico", "PR");
            statesAndTerritoriesDictionary.Add("Virgin Islands", "VI");
            statesAndTerritoriesDictionary.Add("U.S. Minor Outlying Islands", string.Empty);
            statesAndTerritoriesDictionary.Add("Federated States of Micronesia", "FM");
            statesAndTerritoriesDictionary.Add("Marshall Islands", "MH");
            statesAndTerritoriesDictionary.Add("Palau", "PW");
            statesAndTerritoriesDictionary.Add("Canal Zone", "CZ");
            statesAndTerritoriesDictionary.Add("Philippine Islands", "PI");
            statesAndTerritoriesDictionary.Add("Trust Territory of the Pacific Islands", "TT");
            statesAndTerritoriesDictionary.Add("Commonwealth of the Northern Mariana Islands", "CM");
        }
    }
}
