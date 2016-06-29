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
    public class ManagerController : AdminController
    {
       private readonly IUserServices _userService;
        private readonly IUnitofWork _uow;

        public ManagerController(IUnitofWork uow, IUserServices userService) :base(uow)
        {
            _uow = uow;
            _userService = userService;
        }

        public ActionResult Index()
        {
            _userService.Update(new EUserDTO {
                Id = 1,
                FullName = "Nuh Ç.",
                Job = "Csharp yazılım uz",
                Password = "1a1a1",
                UserName="nuh"
            });
            _uow.SaveChanges();
            return View();
        }
       

    }
}