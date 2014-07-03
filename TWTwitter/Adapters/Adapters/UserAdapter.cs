using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TWTwitter.Adapters.Interfaces;
using TWTwitter.Data;
using TWTwitter.Models;

namespace TWTwitter.Adapters.Adapters
{
    public class UserAdapter : IUser
    {
        public List<UserVM> GetFollowing(string id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return db.UserFollows.Where(u => u.FollowedUserId == id).Select(
                u => new UserVM {
                    Id = u.User.Id
                }).ToList();
        }

        public List<UserVM> GetFollowers(string id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return db.UserFollows.Where(u => u.UserId == id).Select(
                u => new UserVM
                {
                    Id = u.FollowedUser.Id
                }).ToList();
        }

        public List<UserVM> GetUsers()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return db.Users.Select(
                u => new UserVM
                {
                    Id = u.Id
                }).ToList();
        }
        
    }
}