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
            //Variable for mission ID
            int MissionID;
            //Determines if mission ID is a valid number
            bool validMissionID = Int32.TryParse(form["MissionID"], out MissionID);

            //Set ViewBag data if the MissionID is a valid number
            if(validMissionID && (MissionID == 1 || MissionID == 2 || MissionID == 3))
            {
                //Brazil Ribeirao Preto Mission
                if (MissionID == 1)
                {
                    ViewBag.MissionName = "Brazil Ribeirao Preto";
                    ViewBag.MissionPresident = "Peter Siegfried Scholz";
                    ViewBag.MissionAddress = "Rua Sao Sebastiao 1003, Centro, 14015-040 Ribeirao Preto, SP, Brazil";
                    ViewBag.Language = "Portuguese";
                    ViewBag.Climate = "Tropical Wet and Dry";
                    ViewBag.DominateReligion = "Roman Catholic";
                    ViewBag.FlagImgFileName = "Brazil_Flag.png";
                }
                //Raleigh North Carolina Mission
                else if (MissionID == 2)
                {
                    ViewBag.MissionName = "Raleigh North Carolina";
                    ViewBag.MissionPresident = "Dennis Roland James";
                    ViewBag.MissionAddress = "5060 Six Forks Rd, Raleigh, NC 27609";
                    ViewBag.Language = "English";
                    ViewBag.Climate = "Humid Subtropical";
                    ViewBag.DominateReligion = "Protestant Christian";
                    ViewBag.FlagImgFileName = "USA_Flag.png";
                }
                //Japan Fukuoka Mission
                else if (MissionID == 3)
                {
                    ViewBag.MissionName = "Japan Fukuoka";
                    ViewBag.MissionPresident = "Bradley C Egan";
                    ViewBag.MissionAddress = "9-16 Hirao-josuimachi, Chuo-ku, Fukuoka-shi, Fukuoka, 810-0029";
                    ViewBag.Language = "Japanese";
                    ViewBag.Climate = "Humid Subtropical";
                    ViewBag.DominateReligion = "Shinto and Buddhism";
                    ViewBag.FlagImgFileName = "Japan_Flag.png";
                }
                //Return view with ViewBag data
                return View("MissionInfo");
            }
            else
            {
                //Return string stating there was an error
                return Content("Error finding data for mission ID " + form["MissionID"]);
            }
            
        }
    }
}