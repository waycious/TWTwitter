using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TWTwitter.Adapters.Adapters;
using TWTwitter.Adapters.Interfaces;
using TWTwitter.Data.Models;

namespace TWTwitter.Controllers
{
    public class apiTweetController : ApiController
    {
        private ITweet _tweetAdapter;
        public apiTweetController()
        {
            _tweetAdapter = new TweetAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_tweetAdapter.GetTweets(null));
        }
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok(_tweetAdapter.GetTweets(id));
        }
        [HttpPost]
        public IHttpActionResult Post(Tweet tweet)
        {
            _tweetAdapter.AddTweet(tweet);
            return Ok();
        }
    }
}
