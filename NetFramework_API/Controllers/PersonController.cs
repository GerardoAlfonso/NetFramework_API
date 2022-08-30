using NetFramework_API.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace NetFramework_API.Controllers
{
    public class PersonController : ApiController
    {
        GenericDTO DTO = new GenericDTO();
        PersonBL personBL = new PersonBL();

        [HttpGet]
        //[Route("GetListPerson")]
        public IHttpActionResult GetListPerson()
        {
            var list = personBL.ListPerson();

            return Ok(list);
        }
    }
}