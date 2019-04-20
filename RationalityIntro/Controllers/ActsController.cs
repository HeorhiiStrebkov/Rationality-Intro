using RationalityIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace RationalityIntro.Controllers
{
    public class ActsController : Controller
    {
        Context db = new Context();

        public ActionResult Act()
        {
            return View(db.Acts);
        }
    }
}
