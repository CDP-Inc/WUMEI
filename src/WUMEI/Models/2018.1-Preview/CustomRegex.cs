namespace WUMEI.Models
{
    /// <summary>
    ///
    /// </summary>
    public class CustomRegex
    {
        /// <summary>
        /// Regex String for Alphabetical characters.
        /// </summary>
        public const string Abc = @"[A-Za-z]+";

        /// <summary>
        /// Regex String for Alphabetical and Special characters.
        /// </summary>
        public const string AbcSpec = @"[A-Za-z#$%&'()*+,\-./:;<>=>?@[\\\]^{|}~]+";

        /// <summary>
        /// Regex String for Numeric characters.
        /// </summary>
        public const string Num = @"[0-9]+";

        /// <summary>
        /// Regex String for Numeric and Special characters.
        /// </summary>
        public const string NumSpec = @"[0-9#$%&'()*+,\-./:;<>=>?@[\\\]^{|}~]+";

        /// <summary>
        /// Regex String for Alphabetical and Numeric characters.
        /// </summary>
        public const string AbcNum = @"[A-Za-z0-9]+";

        /// <summary>
        /// Regex String for Alphabetical, Numeric and Special characters.
        /// </summary>
        public const string AbcNumSpec = @"[A-Za-z0-9#$%&'()*+,\-./:;<>=>?@[\\\]^{|}~]+";

        /// <summary>
        /// Regex String for Alphabetical, Numeric and Space characters.
        /// </summary>
        public const string AbcNumSpace = @"[A-Za-z0-9 ]+";

        /// <summary>
        /// Regex String for Alphabetical, Numeric, Special and Space characters.
        /// </summary>
        public const string AbcNumSpecSpace = @"[A-Za-z0-9 #$%&'()*+,\-./:;<>=>?@[\\\]^{|}~]+";

        /// <summary>
        /// Regex String for Alphabetical, Numeric, Special and Space characters for Name and Address verification.
        /// </summary>
        public const string AbcNumSpecSpaceNameAndAddress = @"[A-Za-z0-9 #$&\*,\-\./<>]+";

        /// <summary>
        /// Regex String for Alphabetical, Special and Space characters.
        /// </summary>
        public const string AbcSpecSpace = @"[A-Za-z #$%&'()*+,\-./:;<>=>?@[\\\]^{|}~]+";

        /// <summary>
        /// Regular expression pattern which enforces a specific value for the action code in the AddUpdateWicVendor
        /// model.
        /// </summary>
        public const string AddUpdateWicVendorActionCode = @"(002)";

        /// <summary>
        /// Regex String for emails, basically just copy of our AbcNumSpec but with the addition of underscore.
        /// </summary>
        public const string Email = @"[A-Za-z0-9#$%&'()*+,\-./:;<>=>?@[\\\]^{|}~_]+";

        /// <summary>
        /// Regex String for Hexadecimal characters.
        /// </summary>
        public const string Hex = @"[0-9A-Fa-f]+";

        /// <summary>
        /// Regex String for Price characters.
        /// </summary>
        public const string Price = @"\d*(\.\d{1,2})";

        /// <summary>
        /// Format for the standard WUMEI 2018 date type - YYYY-MM-DD
        /// </summary>
        public const string StandardDate = @"[0-9]{4}-[0-9]{2}-[0-9]{2}";

        /// <summary>
        /// Format for the standard WUMEI 2018 time type - hh:mm:ss
        /// </summary>
        public const string StandardTime = @"([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]";

        /// <summary>
        /// Format for the Date and Time, Transmission - YYYY-MM-DDThh:mm:ss.sssZ.
        /// </summary>
        public const string TransmissionDT = @"[0-9]{4}-[0-9]{2}-[0-9]{2}T[0-9]{2}:[0-9]{2}:[0-9]{2}\.[0-9]{3}Z";

        /// <summary>
        /// Regular expression pattern which enforces a specific values for yes (Y) or no (N) flag values.
        /// </summary>
        public const string YesNoFlag = @"(Y|N)";
    }
}
