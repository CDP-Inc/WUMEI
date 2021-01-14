namespace WUMEI.Models
{
    /// <summary>
    /// A class containing custom regex strings for model validation.
    /// </summary>
    public static class CustomRegex
    {
        #region Common Patterns

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
        /// Regex String for decimal types with up to 2 digits after the decimal point.
        /// </summary>
        public const string DecimalNum = @"[0-9]*(\.[0-9]{0,2})?";

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
        /// Regex String for Alphabetical, Numeric, Special and Space characters for Name and Address
        /// verification.
        /// </summary>
        public const string AbcNumSpecSpaceNameAndAddress = @"[A-Za-z0-9 #$&'\*,\-\./<>]+";

        /// <summary>
        /// Regex String for Alphabetical, Special and Space characters.
        /// </summary>
        public const string AbcSpecSpace = @"[A-Za-z #$%&'()*+,\-./:;<>=>?@[\\\]^{|}~]+";

        /// <summary>
        /// Regex String for Hexadecimal characters.
        /// </summary>
        public const string Hex = @"[0-9A-Fa-f]+";

        /// <summary>
        /// Regex String for Price characters.
        /// </summary>
        public const string Price = @"\d*(\.\d{1,2})";

        /// <summary>
        /// Format for the standard WUMEI date type - YYYY-MM-DD
        /// </summary>
        public const string StandardDate = @"[0-9]{4}-[0-9]{2}-[0-9]{2}";

        /// <summary>
        /// Format for the standard WUMEI time type - hh:mm:ss
        /// </summary>
        public const string StandardTime = @"([01][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]";

        /// <summary>
        /// Format for the Date and Time, Transmission - YYYY-MM-DDThh:mm:ss.sssZ.
        /// </summary>
        public const string TransmissionDT = @"[0-9]{4}-[0-9]{2}-[0-9]{2}T[0-9]{2}:[0-9]{2}:[0-9]{2}\.[0-9]{3}Z";

        /// <summary>
        /// Regular Expression for valid 2018 vendor types.
        /// </summary>
        public const string Valid2018VendorTypesRegex = @"[C-R,W,Y]";

        /// <summary>
        /// Regular Expression for valid 2020 vendor types.
        /// </summary>
        public const string Valid2020VendorTypesRegex = @"[C-S,W,Y]";

        /// <summary>
        /// A regular expression representing the WUMEI's "anpr" data representation.
        /// </summary>
        public const string AenPattern = @"^[A-Za-z0-9!#$%&'*+\-.\/=?@^_`{|}~]+$";

        /// <summary>
        /// A regular expression representing the WUMEI's "anpr" data representation.
        /// </summary>
        public const string AnprPattern = @"^[A-Za-z0-9 #$'*,\-.\/<>]+$";

        #endregion Common Patterns

        #region Specific Patterns

        /// <summary>
        /// Regular expression pattern which enforces a specific value for the reason code in the add
        /// cardholder model.
        /// </summary>
        public const string AddCardholderReasonCode = "(C007)?";

        /// <summary>
        /// Regular expression pattern which enforces a specific values for yes (Y) or no (N) flag
        /// values.
        /// </summary>
        public const string YesNoFlag = @"(Y|N)";

        /// <summary>
        /// Regular expression pattern which enforces a specific value for the action code in the
        /// AddUpdateWicVendor model.
        /// </summary>
        public const string AddUpdateWicVendorActionCode = @"(002)";

        /// <summary>
        /// Regex String for emails, basically just copy of our AbcNumSpec but with the addition of
        /// underscore.
        /// </summary>
        public const string Email = @"[A-Za-z0-9#$%&'()*+,\-./:;<>=>?@[\\\]^{|}~_]+@[a-z0-9.-]+\.[a-z]{2,}$";

        /// <summary>
        /// Regex String for Ach Request Payment Reason Codes
        /// </summary>
        public const string AchRequestPaymentReasonCodes = @"(P001|P002|P003)";

        /// <summary>
        /// Regex string for Gender which enforces one of the gender codes MFONU as specific values
        /// </summary>
        public const string Gender = @"^(M|F|O|N|U){1}$";

        #endregion Specific Patterns
    }
}
