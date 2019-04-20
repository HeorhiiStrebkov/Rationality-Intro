using RationalityIntro.Models;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace RationalityIntro.Controllers
{
    public class HumansController : Controller
    {
        Context db = new Context();

        public ActionResult Human() 
        {
            return View(db.Humans);
        }

        [HttpGet]
        public ActionResult GetHumans()
        {
            return View(); 
        }
        [HttpPost]
        public string GetHumans(string sex, string profession, string subProperty)
        {
            return sex + " " + profession + " " + subProperty;
        }
    }
}
