using ScoutAssistant.Core.EF;
using ScoutAssistant.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ScoutAssistant.Controllers
{
    public class PlayerController : Controller
    {
        /// <summary>
        /// Loads a list of players from the database.
        /// </summary>
        /// <param name="code">The SchoolCode of the school's players to display.</param>
        /// <returns>
        /// Returns a list of players from the database.
        /// </returns>
        public async Task<ActionResult> List(string code)
        {
            try
            {
                using (ScoutDB db = new ScoutDB())
                {
                    List<PlayerModel> players;
                    if (string.IsNullOrWhiteSpace(code))
                    {
                        ViewBag.Title = "All Players List";

                        players = await (from x in db.vwSchoolPlayerLists
                                         orderby x.PlayerId
                                         select new PlayerModel()
                                         {
                                             SchoolId = x.SchoolId,
                                             PersonId = x.PersonId,
                                             PlayerId = x.PlayerId,
                                             SchoolCode = x.SchoolCode,
                                             ScoutArea = x.ScoutArea,
                                             SchoolName = x.SchoolName,
                                             GreenBookName = x.GreenBookName,
                                             Prefix = x.Prefix,
                                             FirstName = x.FirstName,
                                             MiddleName = x.MiddleName,
                                             LastName = x.LastName,
                                             Suffix = x.Suffix,
                                             FullName = x.FullName,
                                             Phone = x.Phone,
                                             Fax = x.Fax,
                                             Email = x.Email,
                                             Jersey = x.Jersey,
                                             Eligibility = x.Eligibility,
                                             HometownCity = x.HometownCity,
                                             HometownState = x.HometownState,
                                             Height = x.Height,
                                             Weight = x.Weight,
                                             Speed = x.Speed,
                                             Position = x.Position,
                                             PlayerDateModified = x.PlayerDateModified,
                                             PersonDateModified = x.PersonDateModified
                                         }).ToListAsync();
                    }
                    else
                    {
                        ViewBag.Title = string.Format("{0} Players List", code);

                        players = await (from x in db.vwSchoolPlayerLists
                                         where x.SchoolCode == code
                                         orderby x.PlayerId
                                         select new PlayerModel()
                                         {
                                             SchoolId = x.SchoolId,
                                             PersonId = x.PersonId,
                                             PlayerId = x.PlayerId,
                                             SchoolCode = x.SchoolCode,
                                             ScoutArea = x.ScoutArea,
                                             SchoolName = x.SchoolName,
                                             GreenBookName = x.GreenBookName,
                                             Prefix = x.Prefix,
                                             FirstName = x.FirstName,
                                             MiddleName = x.MiddleName,
                                             LastName = x.LastName,
                                             Suffix = x.Suffix,
                                             FullName = x.FullName,
                                             Phone = x.Phone,
                                             Fax = x.Fax,
                                             Email = x.Email,
                                             Jersey = x.Jersey,
                                             Eligibility = x.Eligibility,
                                             HometownCity = x.HometownCity,
                                             HometownState = x.HometownState,
                                             Height = x.Height,
                                             Weight = x.Weight,
                                             Speed = x.Speed,
                                             Position = x.Position,
                                             PlayerDateModified = x.PlayerDateModified,
                                             PersonDateModified = x.PersonDateModified
                                         }).ToListAsync();
                    }

                    if (players == null || players.Count == 0)
                        players = new List<PlayerModel>();

                    return View(players);
                }
            }
            catch (DataException dex)
            {
                ModelState.AddModelError(string.Empty, "Unable to load player list. Try again, and if the problem persists see your system administrator.");
                return RedirectToAction("List");
            }
        }

        /// <summary>
        /// Edits the player associated with the specified identifier.
        /// </summary>
        /// <param name="code">The PlayerId of the player to edit.</param>
        /// <returns>
        /// Returns a form for editing the requested player.
        /// </returns>
        public async Task<ActionResult> Edit(int? code)
        {
            try
            {
                if (code == null || code == 0)
                {
                    ModelState.AddModelError(string.Empty, "Unable to find player. Try again, and if the problem persists see your system administrator.");
                    return RedirectToAction("List");
                }

                using (ScoutDB db = new ScoutDB())
                {
                    PlayerModel player = await (from x in db.vwSchoolPlayerLists
                                                where x.PlayerId == code
                                                select new PlayerModel()
                                                {
                                                    SchoolId = x.SchoolId,
                                                    PersonId = x.PersonId,
                                                    PlayerId = x.PlayerId,
                                                    SchoolCode = x.SchoolCode,
                                                    ScoutArea = x.ScoutArea,
                                                    SchoolName = x.SchoolName,
                                                    GreenBookName = x.GreenBookName,
                                                    Prefix = x.Prefix,
                                                    FirstName = x.FirstName,
                                                    MiddleName = x.MiddleName,
                                                    LastName = x.LastName,
                                                    Suffix = x.Suffix,
                                                    FullName = x.FullName,
                                                    Phone = x.Phone,
                                                    Fax = x.Fax,
                                                    Email = x.Email,
                                                    Jersey = x.Jersey,
                                                    Eligibility = x.Eligibility,
                                                    HometownCity = x.HometownCity,
                                                    HometownState = x.HometownState,
                                                    Height = x.Height,
                                                    Weight = x.Weight,
                                                    Speed = x.Speed,
                                                    Position = x.Position,
                                                    PlayerDateModified = x.PlayerDateModified,
                                                    PersonDateModified = x.PersonDateModified
                                                }).FirstOrDefaultAsync();

                    if (player == null)
                    {
                        ModelState.AddModelError(string.Empty, "Unable to find player. Try again, and if the problem persists see your system administrator.");
                        return RedirectToAction("List");
                    }

                    return View(player);
                }
            }
            catch (DataException dex)
            {
                ModelState.AddModelError(string.Empty, "Unable to load player for edit. Try again, and if the problem persists see your system administrator.");
                return RedirectToAction("List");
            }
        }

        /// <summary>
        /// Validates and edits the specified player in the database with the <see cref="ZoneModel"/> data provided in the form.
        /// </summary>
        /// <param name="code">The PlayerId of the player to edit.</param>
        /// <param name="player">The <see cref="PlayerModel"/> from the form to edit in the database.</param>
        /// <returns>
        /// Returns the user to the List view if successful; otherwise returns to form with validation error messages.
        /// </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int code, [Bind(Include = "PlayerId, PersonId, Prefix, FirstName, MiddleName, LastName, Suffix, HometownCity, HometownState, Position, PersonDateModified, PlayerDateModified")] PlayerModel player)
        {
            try
            {
                if (code == 0)
                {
                    ModelState.AddModelError(string.Empty, "Unable to find player. Try again, and if the problem persists see your system administrator.");
                    return RedirectToAction("List");
                }

                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError(string.Empty, "Unable to edit player. Try again, and if the problem persists see your system administrator.");
                    return View(player);
                }

                using (ScoutDB db = new ScoutDB())
                {
                    vwSchoolPlayerList p = await db.vwSchoolPlayerLists.FirstOrDefaultAsync(x => x.PlayerId == code);

                    if (p == null)
                    {
                        ModelState.AddModelError(string.Empty, "Unable to edit player. Try again, and if the problem persists see your system administrator.");
                        return View(player);
                    }

                    if ((p.PlayerDateModified.ToString() != player.PlayerDateModified.ToString()) || (p.PersonDateModified.ToString() != player.PersonDateModified.ToString()))
                    {
                        if (p.Prefix != player.Prefix)
                            ModelState.AddModelError("Prefix", string.Format("New: {0}", p.Prefix));

                        if (p.FirstName != player.FirstName)
                            ModelState.AddModelError("FirstName", string.Format("New: {0}", p.FirstName));

                        if (p.MiddleName != player.MiddleName)
                            ModelState.AddModelError("MiddleName", string.Format("New: {0}", p.MiddleName));

                        if (p.LastName != player.LastName)
                            ModelState.AddModelError("LastName", string.Format("New: {0}", p.LastName));

                        if (p.Suffix != player.Suffix)
                            ModelState.AddModelError("Suffix", string.Format("New: {0}", p.Suffix));

                        if (p.HometownCity != player.HometownCity)
                            ModelState.AddModelError("HometownCity", string.Format("New: {0}", p.HometownCity));

                        if (p.HometownState != player.HometownState)
                            ModelState.AddModelError("HometownState", string.Format("New: {0}", p.HometownState));

                        if (p.Position != player.Position)
                            ModelState.AddModelError("Position", string.Format("New: {0}", p.Position.ToString()));

                        ModelState.AddModelError(string.Empty, "The player you attempted to edit was successfully edited by another user after you had already loaded the Edit page.<br>The new values are displayed in red under their field for your review.<br>You have the following options:<br><br>1) Click the 'Cancel' button to keep the values entered by the other user<br>2) Click the 'Save Player' button to overwrite the values entered by the other user with the ones you provided.");

                        player.PlayerDateModified = p.PlayerDateModified;
                        player.PersonDateModified = p.PersonDateModified;

                        return View(player);
                    }

                    List<string> changed = new List<string>();

                    Player NewPlayer = await db.Players.FirstOrDefaultAsync(x => x.PlayerId == p.PlayerId);
                    Person NewPerson = await db.Persons.FirstOrDefaultAsync(x => x.PersonId == p.PersonId);

                    if (p.Prefix != player.Prefix)
                    {
                        changed.Add("Prefix: '" + p.Prefix + "' => '" + player.Prefix + "'");
                        NewPerson.Prefix = player.Prefix;
                    }

                    if (p.FirstName != player.FirstName)
                    {
                        changed.Add("FirstName: '" + p.FirstName + "' => '" + player.FirstName + "'");
                        NewPerson.FirstName = player.FirstName;
                    }

                    if (p.MiddleName != player.MiddleName)
                    {
                        changed.Add("MiddleName: '" + p.MiddleName + "' => '" + player.MiddleName + "'");
                        NewPerson.MiddleName = player.MiddleName;
                    }

                    if (p.LastName != player.LastName)
                    {
                        changed.Add("LastName: '" + p.LastName + "' => '" + player.LastName + "'");
                        NewPerson.LastName = player.LastName;
                    }

                    if (p.Suffix != player.Suffix)
                    {
                        changed.Add("Suffix: '" + p.Suffix + "' => '" + player.Suffix + "'");
                        NewPerson.Suffix = player.Suffix;
                    }

                    if (p.HometownCity != player.HometownCity)
                    {
                        changed.Add("HometownCity: '" + p.HometownCity + "' => '" + player.HometownCity + "'");
                        NewPlayer.HometownCity = player.HometownCity;
                    }

                    if (p.HometownState != player.HometownState)
                    {
                        changed.Add("HometownState: '" + p.HometownState + "' => '" + player.HometownState + "'");
                        NewPlayer.HometownState = player.HometownState;
                    }

                    if (p.Position != player.Position)
                    {
                        changed.Add("Position: '" + p.Position.ToString() + "' => '" + player.Position.ToString() + "'");
                        NewPlayer.Position = player.Position;
                    }

                    if (changed.Count == 0)
                    {
                        ModelState.AddModelError(string.Empty, "Unable to edit player. You did not appear to make any changes.");
                        return View(player);
                    }

                    NewPlayer.DateModified = DateTime.Now;
                    NewPerson.DateModified = DateTime.Now;
                    await db.SaveChangesAsync();

                    return RedirectToAction("List");
                }
            }
            catch (DataException dex)
            {
                ModelState.AddModelError(string.Empty, "Unable to edit player. Try again, and if the problem persists see your system administrator.");
                return View(player);
            }
        }

        /// <summary>
        /// Displays the details page for the specified player.
        /// </summary>
        /// <param name="code">The PlayerId of the player to display.</param>
        /// <returns>
        /// Returns all of the data associated with the specified player if successful; otherwise returns the
        /// user to the List view with an error message.
        /// </returns>
        public async Task<ActionResult> Details(int? code)
        {
            var z = this.HttpContext;
            try
            {
                if (code == null || code == 0)
                {
                    ModelState.AddModelError(string.Empty, "Unable to find player. Try again, and if the problem persists see your system administrator.");
                    return RedirectToAction("List");
                }

                using (ScoutDB db = new ScoutDB())
                {
                    PlayerModel player = await (from x in db.vwSchoolPlayerLists
                                                where x.PlayerId == code
                                                select new PlayerModel()
                                                {
                                                    SchoolId = x.SchoolId,
                                                    PersonId = x.PersonId,
                                                    PlayerId = x.PlayerId,
                                                    SchoolCode = x.SchoolCode,
                                                    ScoutArea = x.ScoutArea,
                                                    SchoolName = x.SchoolName,
                                                    GreenBookName = x.GreenBookName,
                                                    Prefix = x.Prefix,
                                                    FirstName = x.FirstName,
                                                    MiddleName = x.MiddleName,
                                                    LastName = x.LastName,
                                                    Suffix = x.Suffix,
                                                    FullName = x.FullName,
                                                    Phone = x.Phone,
                                                    Fax = x.Fax,
                                                    Email = x.Email,
                                                    Jersey = x.Jersey,
                                                    Eligibility = x.Eligibility,
                                                    HometownCity = x.HometownCity,
                                                    HometownState = x.HometownState,
                                                    Height = x.Height,
                                                    Weight = x.Weight,
                                                    Speed = x.Speed,
                                                    Position = x.Position,
                                                    PlayerDateModified = x.PlayerDateModified,
                                                    PersonDateModified = x.PersonDateModified
                                                }).FirstOrDefaultAsync();

                    if (player == null)
                    {
                        ModelState.AddModelError(string.Empty, "Unable to find player. Try again, and if the problem persists see your system administrator.");
                        return RedirectToAction("List");
                    }

                    return View(player);
                }
            }
            catch (DataException dex)
            {
                ModelState.AddModelError(string.Empty, "Unable to find player to display. Try again, and if the problem persists see your system administrator.");
                return RedirectToAction("List");
            }
        }
    }
}