using Business.Business;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class UsersController : ApiController
    {


        [HttpPost]
        [Route("api/register")]
        public Task<HttpResponseMessage> Post([FromBody]Users body)
        {
            UserBusiness user = new UserBusiness();
            user.Register(body);

            return Task.FromResult<HttpResponseMessage> (Request.CreateResponse(HttpStatusCode.Created, new { Message = "TESTE"}));
        }

        [HttpGet]
        [Route("api/List")]
        public Task<HttpResponseMessage> Get([FromBody]dynamic body)
        {


            return Task.FromResult<HttpResponseMessage>(Request.CreateResponse(HttpStatusCode.Created, new { Message = "TESTE" }));
        }
    }
}
