//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoutAssistant.Core.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class School
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public School()
        {
            this.Players = new HashSet<Player>();
            this.SchoolPersonnels = new HashSet<SchoolPersonnel>();
            this.ScoutAssignments = new HashSet<ScoutAssignment>();
        }
    
        public int SchoolId { get; set; }
        public string SchoolCode { get; set; }
        public int ScoutArea { get; set; }
        public string School1 { get; set; }
        public int ESPNId { get; set; }
        public string ShortName { get; set; }
        public string GreenBookName { get; set; }
        public string NickName { get; set; }
        public int AssociationId { get; set; }
        public int DivisionId { get; set; }
        public int ConferenceId { get; set; }
        public Nullable<int> QuestionaireId { get; set; }
        public int AddressId { get; set; }
        public string PressBoxPhone { get; set; }
        public Nullable<int> NationalGradedPlayers { get; set; }
        public Nullable<int> FalconsGradedPlayers { get; set; }
        public Nullable<int> PrimaryScoutId { get; set; }
        public Nullable<int> SecondaryScoutId { get; set; }
        public Nullable<int> BowlGameId { get; set; }
        public Nullable<System.DateTime> GraduationDate { get; set; }
        public Nullable<int> FieldId { get; set; }
        public string SchoolColors { get; set; }
        public string Website { get; set; }
        public bool TransmitFlag { get; set; }
        public bool IsNew { get; set; }
        public Nullable<System.DateTime> WorkoutDate { get; set; }
        public Nullable<System.DateTime> WorkoutDate2 { get; set; }
        public Nullable<int> PrimaryAreaScoutId { get; set; }
        public Nullable<int> RegionalScoutId { get; set; }
        public string Misc1 { get; set; }
        public string Misc2 { get; set; }
        public string Misc3 { get; set; }
        public string RivalsUrl { get; set; }
        public string RivalsAltUrl { get; set; }
        public string Comments { get; set; }
        public Nullable<int> InstitutionId { get; set; }
        public bool BCSSchool { get; set; }
        public bool HideBirthdate { get; set; }
        public int NFLSchoolId { get; set; }
        public string Notes { get; set; }
        public string Restrictions { get; set; }
        public string ClosedDates { get; set; }
        public string InSeasonSchedule { get; set; }
        public Nullable<System.DateTime> RestrictionsCompleted { get; set; }
        public Nullable<int> RestrictionsCompletedBy { get; set; }
        public int FootballAddressId { get; set; }
        public bool isAPT { get; set; }
        public string APTClub { get; set; }
        public bool HBCU { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Deleted { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Address Address1 { get; set; }
        public virtual Association Association { get; set; }
        public virtual BowlGame BowlGame { get; set; }
        public virtual Conference Conference { get; set; }
        public virtual Division Division { get; set; }
        public virtual Document Document { get; set; }
        public virtual Field Field { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Players { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolPersonnel> SchoolPersonnels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScoutAssignment> ScoutAssignments { get; set; }
        public virtual Scout Scout { get; set; }
        public virtual Scout Scout1 { get; set; }
        public virtual Scout Scout2 { get; set; }
        public virtual Scout Scout3 { get; set; }
    }
}
