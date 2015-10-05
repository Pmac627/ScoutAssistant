using System.ComponentModel.DataAnnotations;

namespace ScoutAssistant.Models
{
    /// <summary>
    /// A model for the account login view.
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// Gets or sets the Username.
        /// </summary>
        /// <value>
        /// The Username.
        /// </value>
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [remember me].
        /// </summary>
        /// <value>
        /// true if [remember me]; otherwise, false.
        /// </value>
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}