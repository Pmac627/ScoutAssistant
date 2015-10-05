using ScoutAssistant.Core.EF;
using System;
using System.ComponentModel.DataAnnotations;

namespace ScoutAssistant.Models
{
    public class SchoolDetailsModel : vwSchoolFullList
    {
        /// <summary>
        /// Gets or sets the SchoolCode.
        /// </summary>
        /// <value>
        /// The SchoolCode.
        /// </value>
        [Key]
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
        /// Gets or sets the School.
        /// </summary>
        /// <value>
        /// The School.
        /// </value>
        [Display(Name = "School")]
        public new string School { get { return base.School; } set { base.School = value; } }

        /// <summary>
        /// Gets or sets the ESPN_ID.
        /// </summary>
        /// <value>
        /// The ESPN_ID.
        /// </value>
        [Display(Name = "ESPN ID")]
        public new int ESPN_ID { get { return base.ESPN_ID; } set { base.ESPN_ID = value; } }

        /// <summary>
        /// Gets or sets the SchoolShortName.
        /// </summary>
        /// <value>
        /// The SchoolShortName.
        /// </value>
        [Display(Name = "School Name")]
        public new string SchoolShortName { get { return base.SchoolShortName; } set { base.SchoolShortName = value; } }

        /// <summary>
        /// Gets or sets the GreenBookName.
        /// </summary>
        /// <value>
        /// The GreenBookName.
        /// </value>
        [Display(Name = "School Green Book Name")]
        public new string GreenBookName { get { return base.GreenBookName; } set { base.GreenBookName = value; } }

        /// <summary>
        /// Gets or sets the NickName.
        /// </summary>
        /// <value>
        /// The NickName.
        /// </value>
        [Display(Name = "School NickName")]
        public new string NickName { get { return base.NickName; } set { base.NickName = value; } }

        /// <summary>
        /// Gets or sets the Association.
        /// </summary>
        /// <value>
        /// The Association.
        /// </value>
        [Display(Name = "Association")]
        public new string Association { get { return base.Association; } set { base.Association = value; } }

        /// <summary>
        /// Gets or sets the Division.
        /// </summary>
        /// <value>
        /// The Division.
        /// </value>
        [Display(Name = "Division")]
        public new string Division { get { return base.Division; } set { base.Division = value; } }

        /// <summary>
        /// Gets or sets the Conference.
        /// </summary>
        /// <value>
        /// The Conference.
        /// </value>
        [Display(Name = "Conference")]
        public new string Conference { get { return base.Conference; } set { base.Conference = value; } }

        /// <summary>
        /// Gets or sets the QuestionaireFileName.
        /// </summary>
        /// <value>
        /// The QuestionaireFileName.
        /// </value>
        [Display(Name = "Questionaire File Name")]
        public new string QuestionaireFileName { get { return base.QuestionaireFileName; } set { base.QuestionaireFileName = value; } }

        /// <summary>
        /// Gets or sets the AddressLine1.
        /// </summary>
        /// <value>
        /// The AddressLine1.
        /// </value>
        [Display(Name = "Address 1")]
        public new string AddressLine1 { get { return base.AddressLine1; } set { base.AddressLine1 = value; } }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        /// <value>
        /// The City.
        /// </value>
        [Display(Name = "City")]
        public new string City { get { return base.City; } set { base.City = value; } }

        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        /// <value>
        /// The State.
        /// </value>
        [Display(Name = "State")]
        public new string State { get { return base.State; } set { base.State = value; } }

        /// <summary>
        /// Gets or sets the ZipCode.
        /// </summary>
        /// <value>
        /// The ZipCode.
        /// </value>
        [Display(Name = "ZipCode")]
        public new string ZipCode { get { return base.ZipCode; } set { base.ZipCode = value; } }

        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        /// <value>
        /// The Country.
        /// </value>
        [Display(Name = "Country")]
        public new string Country { get { return base.Country; } set { base.Country = value; } }

        /// <summary>
        /// Gets or sets the HeadCoachName.
        /// </summary>
        /// <value>
        /// The HeadCoachName.
        /// </value>
        [Display(Name = "Head Coach")]
        public new string HeadCoachName { get { return base.HeadCoachName; } set { base.HeadCoachName = value; } }

        /// <summary>
        /// Gets or sets the HeadCoachPhone.
        /// </summary>
        /// <value>
        /// The HeadCoachPhone.
        /// </value>
        [Display(Name = "Head Coach Phone")]
        public new string HeadCoachPhone { get { return base.HeadCoachPhone; } set { base.HeadCoachPhone = value; } }

        /// <summary>
        /// Gets or sets the HeadCoachEmail.
        /// </summary>
        /// <value>
        /// The HeadCoachEmail.
        /// </value>
        [Display(Name = "Head Coach Email")]
        public new string HeadCoachEmail { get { return base.HeadCoachEmail; } set { base.HeadCoachEmail = value; } }

        /// <summary>
        /// Gets or sets the AssistantCoaches.
        /// </summary>
        /// <value>
        /// The AssistantCoaches.
        /// </value>
        [Display(Name = "Assistant Coaches")]
        public new string AssistantCoaches { get { return base.AssistantCoaches; } set { base.AssistantCoaches = value; } }

        /// <summary>
        /// Gets or sets the AssistantPhone.
        /// </summary>
        /// <value>
        /// The AssistantPhone.
        /// </value>
        [Display(Name = "Assistant Phone")]
        public new string AssistantPhone { get { return base.AssistantPhone; } set { base.AssistantPhone = value; } }

        /// <summary>
        /// Gets or sets the VideoDirector.
        /// </summary>
        /// <value>
        /// The VideoDirector.
        /// </value>
        [Display(Name = "Video Director")]
        public new string VideoDirector { get { return base.VideoDirector; } set { base.VideoDirector = value; } }

        /// <summary>
        /// Gets or sets the VideoDirPhone.
        /// </summary>
        /// <value>
        /// The VideoDirPhone.
        /// </value>
        [Display(Name = "Video Director Phone")]
        public new string VideoDirPhone { get { return base.VideoDirPhone; } set { base.VideoDirPhone = value; } }

        /// <summary>
        /// Gets or sets the AthleticDir.
        /// </summary>
        /// <value>
        /// The AthleticDir.
        /// </value>
        [Display(Name = "Athletic Director ")]
        public new string AthleticDir { get { return base.AthleticDir; } set { base.AthleticDir = value; } }

        /// <summary>
        /// Gets or sets the AthleticDirPhone.
        /// </summary>
        /// <value>
        /// The AthleticDirPhone.
        /// </value>
        [Display(Name = "Athletic Director Phone")]
        public new string AthleticDirPhone { get { return base.AthleticDirPhone; } set { base.AthleticDirPhone = value; } }

        /// <summary>
        /// Gets or sets the AthleticDirEmail.
        /// </summary>
        /// <value>
        /// The AthleticDirEmail.
        /// </value>
        [Display(Name = "Athletic Director Email")]
        public new string AthleticDirEmail { get { return base.AthleticDirEmail; } set { base.AthleticDirEmail = value; } }

        /// <summary>
        /// Gets or sets the AthleticDirFax.
        /// </summary>
        /// <value>
        /// The AthleticDirFax.
        /// </value>
        [Display(Name = "Athletic Director Fax")]
        public new string AthleticDirFax { get { return base.AthleticDirFax; } set { base.AthleticDirFax = value; } }

        /// <summary>
        /// Gets or sets the SportsInfoDir.
        /// </summary>
        /// <value>
        /// The SportsInfoDir.
        /// </value>
        [Display(Name = "Sports Info Director")]
        public new string SportsInfoDir { get { return base.SportsInfoDir; } set { base.SportsInfoDir = value; } }

        /// <summary>
        /// Gets or sets the SIDPhone.
        /// </summary>
        /// <value>
        /// The SIDPhone.
        /// </value>
        [Display(Name = "Sports Info Director Phone")]
        public new string SIDPhone { get { return base.SIDPhone; } set { base.SIDPhone = value; } }

        /// <summary>
        /// Gets or sets the SIDFax.
        /// </summary>
        /// <value>
        /// The SIDFax.
        /// </value>
        [Display(Name = "Sports Info Director Fax")]
        public new string SIDFax { get { return base.SIDFax; } set { base.SIDFax = value; } }

        /// <summary>
        /// Gets or sets the SIDEmail.
        /// </summary>
        /// <value>
        /// The SIDEmail.
        /// </value>
        [Display(Name = "Sports Info Director Email")]
        public new string SIDEmail { get { return base.SIDEmail; } set { base.SIDEmail = value; } }

        /// <summary>
        /// Gets or sets the Trainer.
        /// </summary>
        /// <value>
        /// The Trainer.
        /// </value>
        [Display(Name = "Trainer")]
        public new string Trainer { get { return base.Trainer; } set { base.Trainer = value; } }

        /// <summary>
        /// Gets or sets the TrainerPhone.
        /// </summary>
        /// <value>
        /// The TrainerPhone.
        /// </value>
        [Display(Name = "Trainer Phone")]
        public new string TrainerPhone { get { return base.TrainerPhone; } set { base.TrainerPhone = value; } }

        /// <summary>
        /// Gets or sets the StrengthCoach.
        /// </summary>
        /// <value>
        /// The StrengthCoach.
        /// </value>
        [Display(Name = "Strength Coach")]
        public new string StrengthCoach { get { return base.StrengthCoach; } set { base.StrengthCoach = value; } }

        /// <summary>
        /// Gets or sets the StrCoachPhone.
        /// </summary>
        /// <value>
        /// The StrCoachPhone.
        /// </value>
        [Display(Name = "Strength Coach Phone")]
        public new string StrCoachPhone { get { return base.StrCoachPhone; } set { base.StrCoachPhone = value; } }

        /// <summary>
        /// Gets or sets the EquipManager.
        /// </summary>
        /// <value>
        /// The EquipManager.
        /// </value>
        [Display(Name = "Equipment Manager")]
        public new string EquipManager { get { return base.EquipManager; } set { base.EquipManager = value; } }

        /// <summary>
        /// Gets or sets the EquipManagerPhone.
        /// </summary>
        /// <value>
        /// The EquipManagerPhone.
        /// </value>
        [Display(Name = "Equipment Manager Phone")]
        public new string EquipManagerPhone { get { return base.EquipManagerPhone; } set { base.EquipManagerPhone = value; } }

        /// <summary>
        /// Gets or sets the PressBoxPhone.
        /// </summary>
        /// <value>
        /// The PressBoxPhone.
        /// </value>
        [Display(Name = "Press Box Phone")]
        public new string PressBoxPhone { get { return base.PressBoxPhone; } set { base.PressBoxPhone = value; } }

        /// <summary>
        /// Gets or sets the NationalGradedPlayers.
        /// </summary>
        /// <value>
        /// The NationalGradedPlayers.
        /// </value>
        [Display(Name = "Graded Players - National")]
        public new Nullable<int> NationalGradedPlayers { get { return base.NationalGradedPlayers; } set { base.NationalGradedPlayers = value; } }

        /// <summary>
        /// Gets or sets the FalconsGradedPlayers.
        /// </summary>
        /// <value>
        /// The FalconsGradedPlayers.
        /// </value>
        [Display(Name = "Graded Players - Falcons")]
        public new Nullable<int> FalconsGradedPlayers { get { return base.FalconsGradedPlayers; } set { base.FalconsGradedPlayers = value; } }

        /// <summary>
        /// Gets or sets the PrimaryScoutID.
        /// </summary>
        /// <value>
        /// The PrimaryScoutID.
        /// </value>
        [Display(Name = "Primary Scout ID")]
        public new Nullable<int> PrimaryScoutID { get { return base.PrimaryScoutID; } set { base.PrimaryScoutID = value; } }

        /// <summary>
        /// Gets or sets the SecondaryScoutID.
        /// </summary>
        /// <value>
        /// The SecondaryScoutID.
        /// </value>
        [Display(Name = "Secondary Scout ID")]
        public new Nullable<int> SecondaryScoutID { get { return base.SecondaryScoutID; } set { base.SecondaryScoutID = value; } }

        /// <summary>
        /// Gets or sets the BowlGame.
        /// </summary>
        /// <value>
        /// The BowlGame.
        /// </value>
        [Display(Name = "Bowl Game")]
        public new string BowlGame { get { return base.BowlGame; } set { base.BowlGame = value; } }

        /// <summary>
        /// Gets or sets the GradDate.
        /// </summary>
        /// <value>
        /// The GradDate.
        /// </value>
        [Display(Name = "Graduation Date")]
        public new Nullable<DateTime> GradDate { get { return base.GradDate; } set { base.GradDate = value; } }

        /// <summary>
        /// Gets or sets the HomeField.
        /// </summary>
        /// <value>
        /// The HomeField.
        /// </value>
        [Display(Name = "Home Field")]
        public new string HomeField { get { return base.HomeField; } set { base.HomeField = value; } }

        /// <summary>
        /// Gets or sets the Capacity.
        /// </summary>
        /// <value>
        /// The Capacity.
        /// </value>
        [Display(Name = "Capacity")]
        public new Nullable<int> Capacity { get { return base.Capacity; } set { base.Capacity = value; } }

        /// <summary>
        /// Gets or sets the Surface.
        /// </summary>
        /// <value>
        /// The Surface.
        /// </value>
        [Display(Name = "Surface")]
        public new string Surface { get { return base.Surface; } set { base.Surface = value; } }

        /// <summary>
        /// Gets or sets the SchoolColors.
        /// </summary>
        /// <value>
        /// The SchoolColors.
        /// </value>
        [Display(Name = "School Colors")]
        public new string SchoolColors { get { return base.SchoolColors; } set { base.SchoolColors = value; } }

        /// <summary>
        /// Gets or sets the FBWebsite.
        /// </summary>
        /// <value>
        /// The FBWebsite.
        /// </value>
        [Display(Name = "Football Website")]
        public new string FBWebsite { get { return base.FBWebsite; } set { base.FBWebsite = value; } }

        /// <summary>
        /// Gets or sets the TransmitFlag.
        /// </summary>
        /// <value>
        /// The TransmitFlag.
        /// </value>
        [Display(Name = "Transmit Flag")]
        public new bool TransmitFlag { get { return base.TransmitFlag; } set { base.TransmitFlag = value; } }

        /// <summary>
        /// Gets or sets the BowlGameDate.
        /// </summary>
        /// <value>
        /// The BowlGameDate.
        /// </value>
        [Display(Name = "Bowl Game Date")]
        public new Nullable<DateTime> BowlGameDate { get { return base.BowlGameDate; } set { base.BowlGameDate = value; } }

        /// <summary>
        /// Gets or sets the BowlGameText.
        /// </summary>
        /// <value>
        /// The BowlGameText.
        /// </value>
        [Display(Name = "Bowl Game Text")]
        public new string BowlGameText { get { return base.BowlGameText; } set { base.BowlGameText = value; } }

        /// <summary>
        /// Gets or sets the BowlGameOpponent.
        /// </summary>
        /// <value>
        /// The BowlGameOpponent.
        /// </value>
        [Display(Name = "Bowl Game Opponent")]
        public new string BowlGameOpponent { get { return base.BowlGameOpponent; } set { base.BowlGameOpponent = value; } }

        /// <summary>
        /// Gets or sets the BowlGameTV.
        /// </summary>
        /// <value>
        /// The BowlGameTV.
        /// </value>
        [Display(Name = "Bowl Game TV Channel")]
        public new string BowlGameTV { get { return base.BowlGameTV; } set { base.BowlGameTV = value; } }

        /// <summary>
        /// Gets or sets the IsNew.
        /// </summary>
        /// <value>
        /// The IsNew.
        /// </value>
        [Display(Name = "Is New")]
        public new bool IsNew { get { return base.IsNew; } set { base.IsNew = value; } }

        /// <summary>
        /// Gets or sets the WorkoutDate.
        /// </summary>
        /// <value>
        /// The WorkoutDate.
        /// </value>
        [Display(Name = "Workout Date")]
        public new Nullable<DateTime> WorkoutDate { get { return base.WorkoutDate; } set { base.WorkoutDate = value; } }

        /// <summary>
        /// Gets or sets the WorkoutDate2.
        /// </summary>
        /// <value>
        /// The WorkoutDate2.
        /// </value>
        [Display(Name = "Workout Date 2")]
        public new Nullable<DateTime> WorkoutDate2 { get { return base.WorkoutDate2; } set { base.WorkoutDate2 = value; } }

        /// <summary>
        /// Gets or sets the ProLiaison.
        /// </summary>
        /// <value>
        /// The ProLiaison.
        /// </value>
        [Display(Name = "Pro Liaison")]
        public new string ProLiaison { get { return base.ProLiaison; } set { base.ProLiaison = value; } }

        /// <summary>
        /// Gets or sets the ProLiaisonPhone.
        /// </summary>
        /// <value>
        /// The ProLiaisonPhone.
        /// </value>
        [Display(Name = "Pro Liaison Phone")]
        public new string ProLiaisonPhone { get { return base.ProLiaisonPhone; } set { base.ProLiaisonPhone = value; } }

        /// <summary>
        /// Gets or sets the Secretary.
        /// </summary>
        /// <value>
        /// The Secretary.
        /// </value>
        [Display(Name = "Secretary")]
        public new string Secretary { get { return base.Secretary; } set { base.Secretary = value; } }

        /// <summary>
        /// Gets or sets the SecretaryPhone.
        /// </summary>
        /// <value>
        /// The SecretaryPhone.
        /// </value>
        [Display(Name = "Secretary Phone")]
        public new string SecretaryPhone { get { return base.SecretaryPhone; } set { base.SecretaryPhone = value; } }

        /// <summary>
        /// Gets or sets the PrimaryAreaScoutID.
        /// </summary>
        /// <value>
        /// The PrimaryAreaScoutID.
        /// </value>
        [Display(Name = "Primary Area Scout ID")]
        public new string PrimaryAreaScoutID { get { return base.PrimaryAreaScoutID; } set { base.PrimaryAreaScoutID = value; } }

        /// <summary>
        /// Gets or sets the RegionalScoutID.
        /// </summary>
        /// <value>
        /// The RegionalScoutID.
        /// </value>
        [Display(Name = "Regional Scout ID")]
        public new string RegionalScoutID { get { return base.RegionalScoutID; } set { base.RegionalScoutID = value; } }

        /// <summary>
        /// Gets or sets the Misc1.
        /// </summary>
        /// <value>
        /// The Misc1.
        /// </value>
        [Display(Name = "Misc 1")]
        public new string Misc1 { get { return base.Misc1; } set { base.Misc1 = value; } }

        /// <summary>
        /// Gets or sets the Misc2.
        /// </summary>
        /// <value>
        /// The Misc2.
        /// </value>
        [Display(Name = "Misc 2")]
        public new string Misc2 { get { return base.Misc2; } set { base.Misc2 = value; } }

        /// <summary>
        /// Gets or sets the Misc3.
        /// </summary>
        /// <value>
        /// The Misc3.
        /// </value>
        [Display(Name = "Misc 3")]
        public new string Misc3 { get { return base.Misc3; } set { base.Misc3 = value; } }

        /// <summary>
        /// Gets or sets the RivalsURL.
        /// </summary>
        /// <value>
        /// The RivalsURL.
        /// </value>
        [Display(Name = "Rivals URL")]
        public new string RivalsURL { get { return base.RivalsURL; } set { base.RivalsURL = value; } }

        /// <summary>
        /// Gets or sets the RivalsAltURL.
        /// </summary>
        /// <value>
        /// The RivalsAltURL.
        /// </value>
        [Display(Name = "Alternate Rivals URL")]
        public new string RivalsAltURL { get { return base.RivalsAltURL; } set { base.RivalsAltURL = value; } }

        /// <summary>
        /// Gets or sets the Comments.
        /// </summary>
        /// <value>
        /// The Comments.
        /// </value>
        [Display(Name = "Comments")]
        public new string Comments { get { return base.Comments; } set { base.Comments = value; } }

        /// <summary>
        /// Gets or sets the InstitutionID.
        /// </summary>
        /// <value>
        /// The InstitutionID.
        /// </value>
        [Display(Name = "Institution ID")]
        public new Nullable<int> InstitutionID { get { return base.InstitutionID; } set { base.InstitutionID = value; } }

        /// <summary>
        /// Gets or sets the BCSSchool.
        /// </summary>
        /// <value>
        /// The BCSSchool.
        /// </value>
        [Display(Name = "BCS School")]
        public new bool BCSSchool { get { return base.BCSSchool; } set { base.BCSSchool = value; } }

        /// <summary>
        /// Gets or sets the HideBirthdate.
        /// </summary>
        /// <value>
        /// The HideBirthdate.
        /// </value>
        [Display(Name = "Hide Birthdate")]
        public new bool HideBirthdate { get { return base.HideBirthdate; } set { base.HideBirthdate = value; } }

        /// <summary>
        /// Gets or sets the NFLSchoolID.
        /// </summary>
        /// <value>
        /// The NFLSchoolID.
        /// </value>
        [Display(Name = "NFL School ID")]
        public new int NFLSchoolID { get { return base.NFLSchoolID; } set { base.NFLSchoolID = value; } }

        /// <summary>
        /// Gets or sets the Notes.
        /// </summary>
        /// <value>
        /// The Notes.
        /// </value>
        [Display(Name = "Notes")]
        public new string Notes { get { return base.Notes; } set { base.Notes = value; } }

        /// <summary>
        /// Gets or sets the Restrictions.
        /// </summary>
        /// <value>
        /// The Restrictions.
        /// </value>
        [Display(Name = "Restrictions")]
        public new string Restrictions { get { return base.Restrictions; } set { base.Restrictions = value; } }

        /// <summary>
        /// Gets or sets the ClosedDates.
        /// </summary>
        /// <value>
        /// The ClosedDates.
        /// </value>
        [Display(Name = "Closed Dates")]
        public new string ClosedDates { get { return base.ClosedDates; } set { base.ClosedDates = value; } }

        /// <summary>
        /// Gets or sets the InSeasonSchedule.
        /// </summary>
        /// <value>
        /// The InSeasonSchedule.
        /// </value>
        [Display(Name = "In Season Schedule")]
        public new string InSeasonSchedule { get { return base.InSeasonSchedule; } set { base.InSeasonSchedule = value; } }

        /// <summary>
        /// Gets or sets the RestrictionsCompleted.
        /// </summary>
        /// <value>
        /// The RestrictionsCompleted.
        /// </value>
        [Display(Name = "Restrictions Completed")]
        public new Nullable<DateTime> RestrictionsCompleted { get { return base.RestrictionsCompleted; } set { base.RestrictionsCompleted = value; } }

        /// <summary>
        /// Gets or sets the RestrictionsCompletedBy.
        /// </summary>
        /// <value>
        /// The RestrictionsCompletedBy.
        /// </value>
        [Display(Name = "Restrictions Completed By")]
        public new string RestrictionsCompletedBy { get { return base.RestrictionsCompletedBy; } set { base.RestrictionsCompletedBy = value; } }

        /// <summary>
        /// Gets or sets the FootballAddress.
        /// </summary>
        /// <value>
        /// The FootballAddress.
        /// </value>
        [Display(Name = "Football Address")]
        public new string FootballAddress { get { return base.FootballAddress; } set { base.FootballAddress = value; } }

        /// <summary>
        /// Gets or sets the isAPT.
        /// </summary>
        /// <value>
        /// The isAPT.
        /// </value>
        [Display(Name = "Is APT")]
        public new bool isAPT { get { return base.isAPT; } set { base.isAPT = value; } }

        /// <summary>
        /// Gets or sets the APTClub.
        /// </summary>
        /// <value>
        /// The APTClub.
        /// </value>
        [Display(Name = "APT Club")]
        public new string APTClub { get { return base.APTClub; } set { base.APTClub = value; } }

        /// <summary>
        /// Gets or sets the Latitude.
        /// </summary>
        /// <value>
        /// The Latitude.
        /// </value>
        [Display(Name = "Latitude")]
        public new string Latitude { get { return base.Latitude; } set { base.Latitude = value; } }

        /// <summary>
        /// Gets or sets the Longitude.
        /// </summary>
        /// <value>
        /// The Longitude.
        /// </value>
        [Display(Name = "Longitude")]
        public new string Longitude { get { return base.Longitude; } set { base.Longitude = value; } }

        /// <summary>
        /// Gets or sets the HBCU.
        /// </summary>
        /// <value>
        /// The HBCU.
        /// </value>
        [Display(Name = "HBCU")]
        public new bool HBCU { get { return base.HBCU; } set { base.HBCU = value; } }
    }

    public class SchoolListModel : vwSchoolPartialList
    {
        /// <summary>
        /// Gets or sets the SchoolCode.
        /// </summary>
        /// <value>
        /// The SchoolCode.
        /// </value>
        [Key]
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
        /// Gets or sets the School.
        /// </summary>
        /// <value>
        /// The School.
        /// </value>
        [Display(Name = "School")]
        public new string School { get { return base.School; } set { base.School = value; } }

        /// <summary>
        /// Gets or sets the SchoolShortName.
        /// </summary>
        /// <value>
        /// The SchoolShortName.
        /// </value>
        [Display(Name = "School Name")]
        public new string SchoolShortName { get { return base.SchoolShortName; } set { base.SchoolShortName = value; } }

        /// <summary>
        /// Gets or sets the GreenBookName.
        /// </summary>
        /// <value>
        /// The GreenBookName.
        /// </value>
        [Display(Name = "School Green Book Name")]
        public new string GreenBookName { get { return base.GreenBookName; } set { base.GreenBookName = value; } }

        /// <summary>
        /// Gets or sets the NickName.
        /// </summary>
        /// <value>
        /// The NickName.
        /// </value>
        [Display(Name = "School NickName")]
        public new string NickName { get { return base.NickName; } set { base.NickName = value; } }

        /// <summary>
        /// Gets or sets the Association.
        /// </summary>
        /// <value>
        /// The Association.
        /// </value>
        [Display(Name = "Association")]
        public new string Association { get { return base.Association; } set { base.Association = value; } }

        /// <summary>
        /// Gets or sets the Division.
        /// </summary>
        /// <value>
        /// The Division.
        /// </value>
        [Display(Name = "Division")]
        public new string Division { get { return base.Division; } set { base.Division = value; } }

        /// <summary>
        /// Gets or sets the Conference.
        /// </summary>
        /// <value>
        /// The Conference.
        /// </value>
        [Display(Name = "Conference")]
        public new string Conference { get { return base.Conference; } set { base.Conference = value; } }

        /// <summary>
        /// Gets or sets the QuestionaireFileName.
        /// </summary>
        /// <value>
        /// The QuestionaireFileName.
        /// </value>
        [Display(Name = "Questionaire File Name")]
        public new string QuestionaireFileName { get { return base.QuestionaireFileName; } set { base.QuestionaireFileName = value; } }

        /// <summary>
        /// Gets or sets the SchoolAddress.
        /// </summary>
        /// <value>
        /// The SchoolAddress.
        /// </value>
        [Display(Name = "SchoolAddress")]
        public new string SchoolAddress { get { return base.SchoolAddress; } set { base.SchoolAddress = value; } }

        /// <summary>
        /// Gets or sets the FootballAddress.
        /// </summary>
        /// <value>
        /// The FootballAddress.
        /// </value>
        [Display(Name = "Football Address")]
        public new string FootballAddress { get { return base.FootballAddress; } set { base.FootballAddress = value; } }

        /// <summary>
        /// Gets or sets the HeadCoachName.
        /// </summary>
        /// <value>
        /// The HeadCoachName.
        /// </value>
        [Display(Name = "Head Coach")]
        public new string HeadCoachName { get { return base.HeadCoachName; } set { base.HeadCoachName = value; } }

        /// <summary>
        /// Gets or sets the AssistantCoaches.
        /// </summary>
        /// <value>
        /// The AssistantCoaches.
        /// </value>
        [Display(Name = "Assistant Coaches")]
        public new string AssistantCoaches { get { return base.AssistantCoaches; } set { base.AssistantCoaches = value; } }

        /// <summary>
        /// Gets or sets the VideoDirector.
        /// </summary>
        /// <value>
        /// The VideoDirector.
        /// </value>
        [Display(Name = "Video Director")]
        public new string VideoDirector { get { return base.VideoDirector; } set { base.VideoDirector = value; } }

        /// <summary>
        /// Gets or sets the AthleticDir.
        /// </summary>
        /// <value>
        /// The AthleticDir.
        /// </value>
        [Display(Name = "Athletic Director")]
        public new string AthleticDir { get { return base.AthleticDir; } set { base.AthleticDir = value; } }

        /// <summary>
        /// Gets or sets the SportsInfoDir.
        /// </summary>
        /// <value>
        /// The SportsInfoDir.
        /// </value>
        [Display(Name = "Sports Info Director")]
        public new string SportsInfoDir { get { return base.SportsInfoDir; } set { base.SportsInfoDir = value; } }

        /// <summary>
        /// Gets or sets the ProLiaison.
        /// </summary>
        /// <value>
        /// The ProLiaison.
        /// </value>
        [Display(Name = "Pro Liaison")]
        public new string ProLiaison { get { return base.ProLiaison; } set { base.ProLiaison = value; } }

        /// <summary>
        /// Gets or sets the NationalGradedPlayers.
        /// </summary>
        /// <value>
        /// The NationalGradedPlayers.
        /// </value>
        [Display(Name = "Graded Players - National")]
        public new Nullable<int> NationalGradedPlayers { get { return base.NationalGradedPlayers; } set { base.NationalGradedPlayers = value; } }

        /// <summary>
        /// Gets or sets the FalconsGradedPlayers.
        /// </summary>
        /// <value>
        /// The FalconsGradedPlayers.
        /// </value>
        [Display(Name = "Graded Players - Falcons")]
        public new Nullable<int> FalconsGradedPlayers { get { return base.FalconsGradedPlayers; } set { base.FalconsGradedPlayers = value; } }

        /// <summary>
        /// Gets or sets the WorkoutDate.
        /// </summary>
        /// <value>
        /// The WorkoutDate.
        /// </value>
        [Display(Name = "Workout Date")]
        public new Nullable<DateTime> WorkoutDate { get { return base.WorkoutDate; } set { base.WorkoutDate = value; } }

        /// <summary>
        /// Gets or sets the WorkoutDate2.
        /// </summary>
        /// <value>
        /// The WorkoutDate2.
        /// </value>
        [Display(Name = "Workout Date 2")]
        public new Nullable<DateTime> WorkoutDate2 { get { return base.WorkoutDate2; } set { base.WorkoutDate2 = value; } }

        /// <summary>
        /// Gets or sets the PrimaryScoutID.
        /// </summary>
        /// <value>
        /// The PrimaryScoutID.
        /// </value>
        [Display(Name = "Primary Scout ID")]
        public new Nullable<int> PrimaryScoutID { get { return base.PrimaryScoutID; } set { base.PrimaryScoutID = value; } }

        /// <summary>
        /// Gets or sets the SecondaryScoutID.
        /// </summary>
        /// <value>
        /// The SecondaryScoutID.
        /// </value>
        [Display(Name = "Secondary Scout ID")]
        public new Nullable<int> SecondaryScoutID { get { return base.SecondaryScoutID; } set { base.SecondaryScoutID = value; } }

        /// <summary>
        /// Gets or sets the PrimaryAreaScoutID.
        /// </summary>
        /// <value>
        /// The PrimaryAreaScoutID.
        /// </value>
        [Display(Name = "Primary Area Scout ID")]
        public new string PrimaryAreaScoutID { get { return base.PrimaryAreaScoutID; } set { base.PrimaryAreaScoutID = value; } }

        /// <summary>
        /// Gets or sets the RegionalScoutID.
        /// </summary>
        /// <value>
        /// The RegionalScoutID.
        /// </value>
        [Display(Name = "Regional Scout ID")]
        public new string RegionalScoutID { get { return base.RegionalScoutID; } set { base.RegionalScoutID = value; } }

        /// <summary>
        /// Gets or sets the FBWebsite.
        /// </summary>
        /// <value>
        /// The FBWebsite.
        /// </value>
        [Display(Name = "Football Website")]
        public new string FBWebsite { get { return base.FBWebsite; } set { base.FBWebsite = value; } }

        /// <summary>
        /// Gets or sets the RivalsURL.
        /// </summary>
        /// <value>
        /// The RivalsURL.
        /// </value>
        [Display(Name = "Rivals URL")]
        public new string RivalsURL { get { return base.RivalsURL; } set { base.RivalsURL = value; } }

        /// <summary>
        /// Gets or sets the RivalsAltURL.
        /// </summary>
        /// <value>
        /// The RivalsAltURL.
        /// </value>
        [Display(Name = "Alternate Rivals URL")]
        public new string RivalsAltURL { get { return base.RivalsAltURL; } set { base.RivalsAltURL = value; } }

        /// <summary>
        /// Gets or sets the NFLSchoolID.
        /// </summary>
        /// <value>
        /// The NFLSchoolID.
        /// </value>
        [Display(Name = "NFL School ID")]
        public new int NFLSchoolID { get { return base.NFLSchoolID; } set { base.NFLSchoolID = value; } }

        /// <summary>
        /// Gets or sets the ESPN_ID.
        /// </summary>
        /// <value>
        /// The ESPN_ID.
        /// </value>
        [Display(Name = "ESPN ID")]
        public new int ESPN_ID { get { return base.ESPN_ID; } set { base.ESPN_ID = value; } }
    }

    public class SchoolDashboardModel : School
    {
        /// <summary>
        /// Gets or sets the SchoolCode.
        /// </summary>
        /// <value>
        /// The SchoolCode.
        /// </value>
        [Key]
        [Display(Name = "School Code")]
        public new string SchoolCode { get { return base.SchoolCode; } set { base.SchoolCode = value; } }

        /// <summary>
        /// Gets or sets the GreenBookName.
        /// </summary>
        /// <value>
        /// The GreenBookName.
        /// </value>
        [Display(Name = "School Green Book Name")]
        public new string GreenBookName { get { return base.GreenBookName; } set { base.GreenBookName = value; } }
    }
}