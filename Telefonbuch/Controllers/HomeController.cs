﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Telefonbuch.Models;

namespace Telefonbuch.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
