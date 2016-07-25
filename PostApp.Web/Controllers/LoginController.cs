using PostApp.Data.UnitofWork;
using PostApp.DTO.EEntity;
using PostApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostApp.Web.Controllers
{
    public class LoginController : AdminController
    {
        private readonly IUserServices _userService;
        private readonly IUnitofWork _uow;

        public LoginController(IUnitofWork uow, IUserServices userService) :base(uow)
        {
            _uow = uow;
            _userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginControl(ELoginDTO model)
        {
            var result = _userService.GetUserByUserNameAndPassword(model.UserName, model.Password);
            if(result==null)
            return Json("/", JsonRequestBehavior.AllowGet);
            else
                return Json("/Manager", JsonRequestBehavior.AllowGet);

        }

    }
}