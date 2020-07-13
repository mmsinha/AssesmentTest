using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Maersk_Assesment.Models;

namespace Maersk_Assesment.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            BusinessRules rules = new BusinessRules();


            return View(rules);
        }
        [HttpPost]
        public ActionResult Index(BusinessRules rule)
        {
            if (rule.businessRule == DropDownList.ForBook)
            {
                //create a duplicate packing slip for the royalty department.
                //generate a commission payment to the agent. 
            }
            else if (rule.businessRule == DropDownList.ForanUpgradeMembership)
            {
                // apply the upgrade
                //e-mail the owner and inform them of the activation/upgrade. 

            }
            else if (rule.businessRule == DropDownList.ForMemberShip)
            {
                //activate that membership
                //e-mail the owner and inform them of the activation/upgrade. 

            }
            else if (rule.businessRule == DropDownList.ForPhysicalProduct)
            {
                //generate a packing slip for shipping. 
                //generate a commission payment to the agent. 
            }
            else if (rule.businessRule == DropDownList.ForVideoLearning)
            {
                //add a free "First Aid" video to the packing slip (the result of a court
            }

            BusinessRules rules = new BusinessRules();
            return View(rules);
        }

    }
}
