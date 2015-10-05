using ScoutAssistant.Core.EF;
using ScoutAssistant.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using ScoutAssistant.Extensions;

namespace ScoutAssistant.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            try
            {
                using (ScoutDB db = new ScoutDB())
                {
                    List<SchoolDashboardModel> schools = new List<SchoolDashboardModel>();

                    if (this.HttpContext.Profile != null && this.HttpContext.Profile.Context != null)
                    {
                        Person p = this.HttpContext.Profile.Context["Person"].Deserialize<Person>();

                        schools = await (from x in db.ScoutAssignments
                                                                    join y in db.Schools on x.SchoolId equals y.SchoolId
                                                                    where x.ScoutId == p.PersonId
                                                                    && !y.Deleted
                                                                    select new SchoolDashboardModel()
                                                                    {
                                                                        SchoolCode = y.SchoolCode,
                                                                        GreenBookName = y.GreenBookName
                                                                    }).ToListAsync();
                    }

                    if (schools.Count == 0)
                        schools = new List<SchoolDashboardModel>();

                    return View(schools);
                }
            }
            catch (DataException dex)
            {
                ModelState.AddModelError(string.Empty, "Unable to load school list. Try again, and if the problem persists see your system administrator.");
                return RedirectToAction("List");
            }
        }
    }
}