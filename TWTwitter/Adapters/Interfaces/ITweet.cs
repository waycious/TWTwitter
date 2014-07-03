﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWTwitter.Data.Models;
using TWTwitter.Models;

namespace TWTwitter.Adapters.Interfaces
{
    public interface ITweet
    {
        List<TweetVM> GetMyTweets(string id);
        List<TweetVM> GetTweets(string id);
        void AddTweet(Tweet tweet);
    }
}
