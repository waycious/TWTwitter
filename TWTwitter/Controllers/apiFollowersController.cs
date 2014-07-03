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
    public class apiFollowersController : ApiController
    {
        private IUser _userAdapter;
        public apiFollowersController()
        {
            _userAdapter = new UserAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok(_userAdapter.GetFollowers(id));
        }
    }
}
