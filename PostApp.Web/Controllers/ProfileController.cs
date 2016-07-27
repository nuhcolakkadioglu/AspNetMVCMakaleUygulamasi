using PostApp.Data.UnitofWork;
using PostApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostApp.Web.Controllers
{
    public class ProfileController : AdminController
    {
        private readonly IUserServices _userService;
        private readonly IUnitofWork _ouw;


        public ProfileController(IUnitofWork ouw,IUserServices userService):base(ouw)
        {
            _ouw = ouw;
            _userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}