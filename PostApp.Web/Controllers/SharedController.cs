using PostApp.Data.UnitofWork;
using PostApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostApp.Web.Controllers
{
    public class SharedController : PublicController
    {
        private readonly IUserServices _userService;
        private readonly IUnitofWork _uow;

        public SharedController(IUnitofWork uow, IUserServices userService) :base(uow)
        {
            _uow = uow;

            _userService = userService;

        }

        public FileContentResult imgView (int id)
        {
            return new FileContentResult(_userService.GetUserImage(id),"image/png");
        }
    }
}