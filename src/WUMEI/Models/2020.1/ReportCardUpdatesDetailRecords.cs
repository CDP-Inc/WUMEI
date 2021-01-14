using System;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models.V2020
{
    /// <summary>
    /// Collection of Detail Records for the Report Card Updates method.
    /// </summary>
    public class ReportCardUpdatesDetailRecords : V2018.ReportCardUpdatesDetailRecords
    {
        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements Address line 1, Address line 2,
        /// Address city, Address state and Address ZIP code where the card holder receives mail.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder.
        /// </remarks>
        public new CardholderMailingAddress CardholderMailingAddress { get; set; }

        /// <summary>
        /// Gets or sets a constructed data element including the sub-elements first name, middle initial, last name and suffix.
        /// </summary>
        /// <remarks>
        /// Required if the data element was provided in Add Cardholder/Card or Update Card/Cardholder.
        /// </remarks>
        public new ContactName CardholderName { get; set; }
    }
}