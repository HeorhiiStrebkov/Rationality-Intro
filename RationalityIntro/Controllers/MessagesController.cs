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
    public class MessagesController : Controller
    {
        Context db = new Context();

        public ActionResult Message()
        {
            return View(db.Messages);
        }
    }
}
