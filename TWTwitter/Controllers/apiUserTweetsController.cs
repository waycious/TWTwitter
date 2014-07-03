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
    public class apiUserTweetsController : ApiController
    {
        private ITweet _tweetAdapter;
        public apiUserTweetsController()
        {
            _tweetAdapter = new TweetAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok(_tweetAdapter.GetMyTweets(id));
        }
    }
}
