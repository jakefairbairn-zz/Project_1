using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_1.Models;

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
        public ActionResult MissionInfo(FormCollection form)
        {
            int MissionID;

            bool validMissionID = Int32.TryParse(form["MissionID"], out MissionID);

            if(validMissionID)
            {
                //Brazil Ribeirao Preto Mission
                if (MissionID == 1)
                {
                    ViewBag.MissionName = "Brazil Ribeirao Preto";
                    ViewBag.MissionPresident = "Peter Siegfried Scholz";
                    ViewBag.MissionAddress = "Rua Sao Sebastiao 1003, Centro, 14015-040 Ribeirao Preto, SP, Brazil";
                    ViewBag.Climate = "Tropical Wet and Dry";
                    ViewBag.DominateReligion = "Roman Catholic";
                    ViewBag.FlagImgFileName = "";
                }
                //Raleigh North Carolina Mission
                else if (MissionID == 2)
                {
                    ViewBag.MissionName = "Raleigh North Carolina";
                    ViewBag.MissionPresident = "Dennis Roland James";
                    ViewBag.MissionAddress = "5060 Six Forks Rd, Raleigh, NC 27609";
                    ViewBag.Climate = "Humid Subtropical";
                    ViewBag.DominateReligion = "Protestant Christian";
                    ViewBag.FlagImgFileName = "";
                }
                //Japan Fukuoka Mission
                else if (MissionID == 3)
                {
                    ViewBag.MissionName = "Japan Fukuoka";
                    ViewBag.MissionPresident = "Bradley C Egan";
                    ViewBag.MissionAddress = "9-16 Hirao-josuimachi, Chuo-ku, Fukuoka-shi, Fukuoka, 810-0029";
                    ViewBag.Climate = "Humid Subtropical";
                    ViewBag.DominateReligion = "Shinto and Buddhism";
                    ViewBag.FlagImgFileName = "";
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