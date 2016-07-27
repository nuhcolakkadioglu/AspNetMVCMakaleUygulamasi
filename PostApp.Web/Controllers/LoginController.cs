using PostApp.Data.UnitofWork;
using PostApp.DTO.EEntity;
using PostApp.Services.Interfaces;
using PostApp.Utilities.SessionOperations;
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
        private  SessionContext _sessionContext;

        public LoginController(IUnitofWork uow, IUserServices userService) :base(uow)
        {
            _uow = uow;
            _userService = userService;
            _sessionContext = new SessionContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginControl(ELoginDTO model)
        {
            var result = _userService.GetUserByUserNameAndPassword(model.UserName, model.Password);
            if(result!=null)
            {
                AutoMapper.Mapper.DynamicMap(result, _sessionContext);

                Session["SessionContext"] = _sessionContext;

                return Json("/Manager", JsonRequestBehavior.AllowGet);
            }
            else
                return Json(null, JsonRequestBehavior.AllowGet);


        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return Json("", JsonRequestBehavior.AllowGet);
        }

    }
}