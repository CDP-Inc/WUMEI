using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Data element containing the 12 sub elements required for the Point of Sale Data Code.
    /// </summary>
    public class PosDataCode
    {
        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardCaptureCapability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardDataInputCapability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardDataInputMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardDataOutputCapability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardDataPresent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardholderAuthenticationCapability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardholderAuthenticationEntity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardholderAuthenticationMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string CardholderPresent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string OperatingEnvironment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string PinCaptureCapability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(1, MinimumLength = 1)]
        public string TerminalOutputCapability { get; set; }
    }
}