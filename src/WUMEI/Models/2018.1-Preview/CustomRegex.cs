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
        /// Regex String for Hexadecimal characters.
        /// </summary>
        public const string Hex = @"[0-9A-Fa-f]+";

        /// <summary>
        /// Regex String for Price characters.
        /// </summary>
        public const string Price = @"\d*(\.\d{1,2})";
    }
}
