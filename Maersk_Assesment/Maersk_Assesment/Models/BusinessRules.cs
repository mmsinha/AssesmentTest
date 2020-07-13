using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maersk_Assesment.Models
{
    public enum DropDownList
    {
        ForPhysicalProduct=0,
        ForBook=1,
        ForMemberShip=2,
        ForanUpgradeMembership=3,
        ForVideoLearning=4
    }
    public class BusinessRules
    {
        public DropDownList businessRule { get; set; }  
        public IEnumerable<SelectListItem> dropdownRuleList { get; set; }
        public BusinessRules()  
        {
            dropdownRuleList = Enum.GetNames(typeof(DropDownList)).Select(name => new SelectListItem()  
            {  
                Text = name,  
                Value = name  
            });  
        }
    }
}