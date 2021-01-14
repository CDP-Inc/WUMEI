using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace WUMEI.Models.V2018
{
    /// <summary>
    /// Data element containing the 12 sub elements required for the Point of Sale Data Code.
    /// </summary>
    [XmlRoot(ElementName = "PosDataCode")]
    public class PosDataCode
    {
        /// <summary>
        /// Gets or sets a sub-element (3) of POS data code that indicates whether or not the
        /// terminal has the ability to capture a card.
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardCaptureCapability { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (1) of POS data code that indicates the primary means of
        /// getting the information on the card into the terminal.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string CardDataInputCapability { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (7) of POS data code that indicates the method used to input
        /// the information from the card to the terminal.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string CardDataInputMode { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (10) of POS data code that the ability of the terminal
        /// to print/display messages.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string CardDataOutputCapability { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (6) of POS data code that indicates if the cardholder is present at
        /// the POS or not and if not why not.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string CardDataPresent { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (2) of POS data code that indicates the primary means of
        /// verifying the cardholder at this terminal.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string CardholderAuthenticationCapability { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (9) of POS data code that indicates the entity verifying the cardholder.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string CardholderAuthenticationEntity { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (8) of POS data code that indicates the method for verifying the cardholder.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string CardholderAuthenticationMethod { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (5) of POS data code that indicates if the cardholder is
        /// present at the POS or not and if not why not.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string CardholderPresent { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (4) of POS data code that indicates if the terminal is
        /// attended by the Card acceptor and its location.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string OperatingEnvironment { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (12) of POS data code that indicates the length of PIN
        /// which a terminal is capable of capturing.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string PinCaptureCapability { get; set; }

        /// <summary>
        /// Gets or sets a sub-element (11) of POS data code that indicates the ability
        /// of the terminal to print/display messages.
        /// </summary>
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string TerminalOutputCapability { get; set; }
    }
}
