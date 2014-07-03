using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWTwitter.Models;

namespace TWTwitter.Adapters.Interfaces
{
    public interface IUser
    {
        List<UserVM> GetFollowing(string id);
        List<UserVM> GetFollowers(string id);
        List<UserVM> GetUsers();
    }
}
