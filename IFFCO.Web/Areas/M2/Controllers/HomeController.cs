using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IFFCO.HRMS.Service;
using IFFCO.HRMS.Shared.Entities;
using IFFCO.VTMS.Web.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace IFFCO.VTMS.Web.Areas.M2.Controllers
{
    [Area("M2")]
    public class HomeController : BaseController<ViewModelDashBoardChart>
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
