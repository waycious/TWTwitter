using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TWTwitter.Adapters.Adapters;
using TWTwitter.Adapters.Interfaces;

namespace TWTwitter.Controllers
{
    public class apiUsersController : ApiController
    {
        private IUser _userAdapter;
        public apiUsersController()
        {
            _userAdapter = new UserAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_userAdapter.GetUsers());
        }
    }
}
