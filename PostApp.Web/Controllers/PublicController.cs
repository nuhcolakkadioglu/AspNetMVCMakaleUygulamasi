using PostApp.Data.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostApp.Web.Controllers
{
    public class PublicController : BaseController
    {
        public PublicController(IUnitofWork uow):base(uow)
        {

        }
    }
}