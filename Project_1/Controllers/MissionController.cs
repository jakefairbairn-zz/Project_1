using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitMissionInfoForm(FormCollection form)
        {
            int MissionID;

            bool validMissionID = Int32.TryParse(form["MissionID"], out MissionID);

            if(validMissionID)
            {
                if (MissionID == 1)
                {
                    return View("BrazilRibeiraoPreto");
                }
                else if (MissionID == 2)
                {
                    return View("USANorthCarolinaRaleigh");
                }
                else if (MissionID == 3)
                {
                    return View("JapanFukuoka");
                }
                return View("MissionInfo");
            }
            else
            {
                return Content("Error finding data for mission ID " + form["MissionID"]);
            }
            
        }
    }
}