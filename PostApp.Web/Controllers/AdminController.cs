using PostApp.Data.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostApp.Web.Controllers
{
    public class AdminController : BaseController
    {
        public AdminController(IUnitofWork uow) :base(uow)
        {

        }
    }
}