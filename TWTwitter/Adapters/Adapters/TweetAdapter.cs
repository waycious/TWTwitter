using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TWTwitter.Adapters.Interfaces;
using TWTwitter.Data;
using TWTwitter.Data.Models;
using TWTwitter.Models;

namespace TWTwitter.Adapters.Adapters
{
    public class TweetAdapter : ITweet
    {
        public List<TweetVM> GetMyTweets(string id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return db.Tweets.Where(t => t.TargetId == id).Select(
                t => new TweetVM
                {
                    Id = t.Id,
                    Text = t.Text,
                    UserId = t.UserId,
                    TargetId = t.TargetId
                }).ToList();
        }
        public List<TweetVM> GetTweets(string id = null)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            if (id == null)
                return db.Tweets.Select(
                    t => new TweetVM
                    {
                        Id = t.Id,
                        Text = t.Text,
                        UserId = t.UserId,
                        TargetId = t.TargetId
                    }).ToList();
            else
                return db.UserFollows.Where(
                    u => u.UserId == id).SelectMany(
                    f => f.FollowedUser.Messages).Select(
                    t => new TweetVM
                    {
                        Id = t.Id,
                        Text = t.Text,
                        UserId = t.UserId,
                        TargetId = t.TargetId
                    }).ToList();
        }
        public void AddTweet(Tweet tweet)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Tweets.Add(tweet);
            db.SaveChanges();
        }
    }
}