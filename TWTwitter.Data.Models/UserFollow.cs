using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWTwitter.Data.Models
{
    public class UserFollow
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string FollowedUserId { get; set; }
        public virtual User FollowedUser { get; set; }
    }
}
