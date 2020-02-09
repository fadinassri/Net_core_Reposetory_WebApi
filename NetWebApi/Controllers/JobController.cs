using NetWebApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetWebApi.Controllers
{
    public class JobController : ApiController
    {
        public IHttpActionResult get()
        {
            UnitOfWork u = new UnitOfWork();
            var Data = u.Jobs.GetAll();
            
            return Json(Data);
        }
    }
}
