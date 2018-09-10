using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WUMEI.Models._2018._1_Preview
{
    public class VendorMailingZipCode
    {
        /// <summary>
        /// A sub-element of Address ZIP code identifying the U.S. postal code associated with the address specified.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [StringLength(5)]
        [RegularExpression(CustomRegex.Num)]
        public string ZipCodePrimary { get; set; }

        /// <summary>
        /// A sub-element of Address ZIP code, identifying the ZIP+4 U.S. postal codes for the address specified.
        /// </summary>
        [StringLength(4)]
        [RegularExpression(CustomRegex.Num)]
        public string ZipCodeExtended { get; set; }
    }
}
