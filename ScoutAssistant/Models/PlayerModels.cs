using ScoutAssistant.Core.EF;
using System;
using System.ComponentModel.DataAnnotations;

namespace ScoutAssistant.Models
{
    public class PlayerModel : vwSchoolPlayerList
    {
        /// <summary>
        /// Gets or sets the PlayerId.
        /// </summary>
        /// <value>
        /// The PlayerId.
        /// </value>
        [Key]
        [Display(Name = "Player Id #")]
        public new int PlayerId { get { return base.PlayerId; } set { base.PlayerId = value; } }

        /// <summary>
        /// Gets or sets the SchoolId.
        /// </summary>
        /// <value>
        /// The SchoolId.
        /// </value>
        [Display(Name = "School Id #")]
        public new int SchoolId { get { return base.SchoolId; } set { base.SchoolId = value; } }

        /// <summary>
        /// Gets or sets the PersonId.
        /// </summary>
        /// <value>
        /// The PersonId.
        /// </value>
        [Display(Name = "Person Id #")]
        public new int PersonId { get { return base.PersonId; } set { base.PersonId = value; } }

        /// <summary>
        /// Gets or sets the SchoolCode.
        /// </summary>
        /// <value>
        /// The SchoolCode.
        /// </value>
        [Display(Name = "School Code")]
        public new string SchoolCode { get { return base.SchoolCode; } set { base.SchoolCode = value; } }

        /// <summary>
        /// Gets or sets the ScoutArea.
        /// </summary>
        /// <value>
        /// The ScoutArea.
        /// </value>
        [Display(Name = "Scout Area")]
        public new int ScoutArea { get { return base.ScoutArea; } set { base.ScoutArea = value; } }

        /// <summary>
        /// Gets or sets the SchoolName.
        /// </summary>
        /// <value>
        /// The SchoolName.
        /// </value>
        [Display(Name = "School Name")]
        public new string SchoolName { get { return base.SchoolName; } set { base.SchoolName = value; } }

        /// <summary>
        /// Gets or sets the GreenBookName.
        /// </summary>
        /// <value>
        /// The GreenBookName.
        /// </value>
        [Display(Name = "School Green Book Name")]
        public new string GreenBookName { get { return base.GreenBookName; } set { base.GreenBookName = value; } }

        /// <summary>
        /// Gets or sets the Prefix.
        /// </summary>
        /// <value>
        /// The Prefix.
        /// </value>
        [Display(Name = "Prefix")]
        [MaxLength(10)]
        public new string Prefix { get { return base.Prefix; } set { base.Prefix = value; } }

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        /// <value>
        /// The FirstName.
        /// </value>
        [Required]
        [Display(Name = "First Name")]
        [MaxLength(40)]
        public new string FirstName { get { return base.FirstName; } set { base.FirstName = value; } }

        /// <summary>
        /// Gets or sets the MiddleName.
        /// </summary>
        /// <value>
        /// The MiddleName.
        /// </value>
        [Display(Name = "Middle Name")]
        [MaxLength(40)]
        public new string MiddleName { get { return base.MiddleName; } set { base.MiddleName = value; } }

        /// <summary>
        /// Gets or sets the LastName.
        /// </summary>
        /// <value>
        /// The LastName.
        /// </value>
        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(40)]
        public new string LastName { get { return base.LastName; } set { base.LastName = value; } }

        /// <summary>
        /// Gets or sets the Suffix.
        /// </summary>
        /// <value>
        /// The Suffix.
        /// </value>
        [Display(Name = "Suffix")]
        [MaxLength(10)]
        public new string Suffix { get { return base.Suffix; } set { base.Suffix = value; } }

        /// <summary>
        /// Gets or sets the FullName.
        /// </summary>
        /// <value>
        /// The FullName.
        /// </value>
        [Display(Name = "Full Name")]
        public new string FullName { get { return base.FullName; } set { base.FullName = value; } }

        /// <summary>
        /// Gets or sets the Phone.
        /// </summary>
        /// <value>
        /// The Phone.
        /// </value>
        [Display(Name = "Phone")]
        public new string Phone { get { return base.Phone; } set { base.Phone = value; } }

        /// <summary>
        /// Gets or sets the Fax.
        /// </summary>
        /// <value>
        /// The Fax.
        /// </value>
        [Display(Name = "Fax")]
        public new string Fax { get { return base.Fax; } set { base.Fax = value; } }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        /// <value>
        /// The Email.
        /// </value>
        [Display(Name = "Email")]
        public new string Email { get { return base.Email; } set { base.Email = value; } }

        /// <summary>
        /// Gets or sets the Jersey.
        /// </summary>
        /// <value>
        /// The Jersey.
        /// </value>
        [Display(Name = "Jersey #")]
        public new Nullable<int> Jersey { get { return base.Jersey; } set { base.Jersey = value; } }

        /// <summary>
        /// Gets or sets the Eligibility.
        /// </summary>
        /// <value>
        /// The Eligibility.
        /// </value>
        [Display(Name = "Eligibility")]
        public new string Eligibility { get { return base.Eligibility; } set { base.Eligibility = value; } }

        /// <summary>
        /// Gets or sets the HometownCity.
        /// </summary>
        /// <value>
        /// The HometownCity.
        /// </value>
        [MaxLength(50)]
        [Display(Name = "Hometown City")]
        public new string HometownCity { get { return base.HometownCity; } set { base.HometownCity = value; } }

        /// <summary>
        /// Gets or sets the HometownState.
        /// </summary>
        /// <value>
        /// The HometownState.
        /// </value>
        [MaxLength(2)]
        [Display(Name = "Hometown State")]
        public new string HometownState { get { return base.HometownState; } set { base.HometownState = value; } }

        /// <summary>
        /// Gets or sets the Height.
        /// </summary>
        /// <value>
        /// The Height.
        /// </value>
        [Display(Name = "Height")]
        public new Nullable<int> Height { get { return base.Height; } set { base.Height = value; } }

        /// <summary>
        /// Gets or sets the Weight.
        /// </summary>
        /// <value>
        /// The Weight.
        /// </value>
        [Display(Name = "Weight")]
        public new Nullable<decimal> Weight { get { return base.Weight; } set { base.Weight = value; } }

        /// <summary>
        /// Gets or sets the Speed.
        /// </summary>
        /// <value>
        /// The Speed.
        /// </value>
        [Display(Name = "Speed")]
        public new Nullable<decimal> Speed { get { return base.Speed; } set { base.Speed = value; } }

        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        /// <value>
        /// The Position.
        /// </value>
        [MaxLength(50)]
        [Display(Name = "Position")]
        public new string Position { get { return base.Position; } set { base.Position = value; } }

        /// <summary>
        /// Gets or sets the PlayerDateModified.
        /// </summary>
        /// <value>
        /// The PlayerDateModified.
        /// </value>
        [Display(Name = "PlayerDateModified")]
        public new DateTime PlayerDateModified { get { return base.PlayerDateModified; } set { base.PlayerDateModified = value; } }

        /// <summary>
        /// Gets or sets the PersonDateModified.
        /// </summary>
        /// <value>
        /// The PersonDateModified.
        /// </value>
        [Display(Name = "PersonDateModified")]
        public new DateTime PersonDateModified { get { return base.PersonDateModified; } set { base.PersonDateModified = value; } }
    }
}