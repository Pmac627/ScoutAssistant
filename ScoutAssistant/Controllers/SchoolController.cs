using ScoutAssistant.Core.EF;
using ScoutAssistant.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ScoutAssistant.Controllers
{
    [Authorize]
    public class SchoolController : Controller
    {
        /// <summary>
        /// Loads a list of schools from the database.
        /// </summary>
        /// <returns>
        /// Returns a list of schools from the database.
        /// </returns>
        public async Task<ActionResult> List()
        {
            try
            {
                using (ScoutDB db = new ScoutDB())
                {
                    List<SchoolListModel> schools = await (from x in db.vwSchoolPartialLists
                                                           select new SchoolListModel()
                                                           {
                                                               SchoolCode = x.SchoolCode,
                                                               ScoutArea = x.ScoutArea,
                                                               School = x.School,
                                                               SchoolShortName = x.SchoolShortName,
                                                               GreenBookName = x.GreenBookName,
                                                               NickName = x.NickName,
                                                               Association = x.Association,
                                                               Division = x.Division,
                                                               Conference = x.Conference,
                                                               QuestionaireFileName = x.QuestionaireFileName,
                                                               SchoolAddress = x.SchoolAddress,
                                                               FootballAddress = x.FootballAddress,
                                                               HeadCoachName = x.HeadCoachName,
                                                               AssistantCoaches = x.AssistantCoaches,
                                                               VideoDirector = x.VideoDirector,
                                                               AthleticDir = x.AthleticDir,
                                                               SportsInfoDir = x.SportsInfoDir,
                                                               ProLiaison = x.ProLiaison,
                                                               NationalGradedPlayers = x.NationalGradedPlayers,
                                                               FalconsGradedPlayers = x.FalconsGradedPlayers,
                                                               WorkoutDate = x.WorkoutDate,
                                                               WorkoutDate2 = x.WorkoutDate2,
                                                               PrimaryScoutID = x.PrimaryScoutID,
                                                               SecondaryScoutID = x.SecondaryScoutID,
                                                               PrimaryAreaScoutID = x.PrimaryAreaScoutID,
                                                               RegionalScoutID = x.RegionalScoutID,
                                                               FBWebsite = x.FBWebsite,
                                                               RivalsURL = x.RivalsURL,
                                                               RivalsAltURL = x.RivalsAltURL,
                                                               NFLSchoolID = x.NFLSchoolID,
                                                               ESPN_ID = x.ESPN_ID
                                                           }).ToListAsync();

                    if (schools == null || schools.Count == 0)
                        schools = new List<SchoolListModel>();

                    return View(schools);
                }
            }
            catch (DataException dex)
            {
                ModelState.AddModelError(string.Empty, "Unable to load school list. Try again, and if the problem persists see your system administrator.");
                return RedirectToAction("List");
            }
        }

        /// <summary>
        /// Displays the details page for the specified school.
        /// </summary>
        /// <param name="code">The SchoolCode of the school to display.</param>
        /// <returns>
        /// Returns all of the data associated with the specified school if successful; otherwise returns the
        /// user to the List view with an error message.
        /// </returns>
        public async Task<ActionResult> Details(string code)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(code))
                {
                    ModelState.AddModelError(string.Empty, "Unable to find school. Try again, and if the problem persists see your system administrator.");
                    return RedirectToAction("List");
                }

                using (ScoutDB db = new ScoutDB())
                {
                    SchoolDetailsModel school = await (from x in db.vwSchoolFullLists
                                                       where x.SchoolCode == code
                                                       select new SchoolDetailsModel()
                                                       {
                                                           SchoolCode = x.SchoolCode,
                                                           ScoutArea = x.ScoutArea,
                                                           School = x.School,
                                                           ESPN_ID = x.ESPN_ID,
                                                           SchoolShortName = x.SchoolShortName,
                                                           GreenBookName = x.GreenBookName,
                                                           NickName = x.NickName,
                                                           Association = x.Association,
                                                           Division = x.Division,
                                                           Conference = x.Conference,
                                                           QuestionaireFileName = x.QuestionaireFileName,
                                                           AddressLine1 = x.AddressLine1,
                                                           City = x.City,
                                                           State = x.State,
                                                           ZipCode = x.ZipCode,
                                                           Country = x.Country,
                                                           HeadCoachName = x.HeadCoachName,
                                                           HeadCoachPhone = x.HeadCoachPhone,
                                                           HeadCoachEmail = x.HeadCoachEmail,
                                                           AssistantCoaches = x.AssistantCoaches,
                                                           AssistantPhone = x.AssistantPhone,
                                                           VideoDirector = x.VideoDirector,
                                                           VideoDirPhone = x.VideoDirPhone,
                                                           AthleticDir = x.AthleticDir,
                                                           AthleticDirPhone = x.AthleticDirPhone,
                                                           AthleticDirEmail = x.AthleticDirEmail,
                                                           AthleticDirFax = x.AthleticDirFax,
                                                           SportsInfoDir = x.SportsInfoDir,
                                                           SIDPhone = x.SIDPhone,
                                                           SIDFax = x.SIDFax,
                                                           SIDEmail = x.SIDEmail,
                                                           Trainer = x.Trainer,
                                                           TrainerPhone = x.TrainerPhone,
                                                           StrengthCoach = x.StrengthCoach,
                                                           StrCoachPhone = x.StrCoachPhone,
                                                           EquipManager = x.EquipManager,
                                                           EquipManagerPhone = x.EquipManagerPhone,
                                                           PressBoxPhone = x.PressBoxPhone,
                                                           NationalGradedPlayers = x.NationalGradedPlayers,
                                                           FalconsGradedPlayers = x.FalconsGradedPlayers,
                                                           PrimaryScoutID = x.PrimaryScoutID,
                                                           SecondaryScoutID = x.SecondaryScoutID,
                                                           BowlGame = x.BowlGame,
                                                           GradDate = x.GradDate,
                                                           HomeField = x.HomeField,
                                                           Capacity = x.Capacity,
                                                           Surface = x.Surface,
                                                           SchoolColors = x.SchoolColors,
                                                           FBWebsite = x.FBWebsite,
                                                           TransmitFlag = x.TransmitFlag,
                                                           BowlGameDate = x.BowlGameDate,
                                                           BowlGameText = x.BowlGameText,
                                                           BowlGameOpponent = x.BowlGameOpponent,
                                                           BowlGameTV = x.BowlGameTV,
                                                           IsNew = x.IsNew,
                                                           WorkoutDate = x.WorkoutDate,
                                                           WorkoutDate2 = x.WorkoutDate2,
                                                           ProLiaison = x.ProLiaison,
                                                           ProLiaisonPhone = x.ProLiaisonPhone,
                                                           Secretary = x.Secretary,
                                                           SecretaryPhone = x.SecretaryPhone,
                                                           PrimaryAreaScoutID = x.PrimaryAreaScoutID,
                                                           RegionalScoutID = x.RegionalScoutID,
                                                           Misc1 = x.Misc1,
                                                           Misc2 = x.Misc2,
                                                           Misc3 = x.Misc3,
                                                           RivalsURL = x.RivalsURL,
                                                           RivalsAltURL = x.RivalsAltURL,
                                                           Comments = x.Comments,
                                                           InstitutionID = x.InstitutionID,
                                                           BCSSchool = x.BCSSchool,
                                                           HideBirthdate = x.HideBirthdate,
                                                           NFLSchoolID = x.NFLSchoolID,
                                                           Notes = x.Notes,
                                                           Restrictions = x.Restrictions,
                                                           ClosedDates = x.ClosedDates,
                                                           InSeasonSchedule = x.InSeasonSchedule,
                                                           RestrictionsCompleted = x.RestrictionsCompleted,
                                                           RestrictionsCompletedBy = x.RestrictionsCompletedBy,
                                                           FootballAddress = x.FootballAddress,
                                                           isAPT = x.isAPT,
                                                           APTClub = x.APTClub,
                                                           Latitude = x.Latitude,
                                                           Longitude = x.Longitude,
                                                           HBCU = x.HBCU
                                                       }).FirstOrDefaultAsync();

                    if (school == null)
                    {
                        ModelState.AddModelError(string.Empty, "Unable to find school. Try again, and if the problem persists see your system administrator.");
                        return RedirectToAction("List");
                    }

                    return View(school);
                }
            }
            catch (DataException dex)
            {
                ModelState.AddModelError(string.Empty, "Unable to find school to display. Try again, and if the problem persists see your system administrator.");
                return RedirectToAction("List");
            }
        }
    }
}