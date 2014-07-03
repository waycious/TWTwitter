using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWTwitter.Data.Models
{
    public class User
    {
        public string Id { get; set; }
        public virtual List<Tweet> Tweets { get; set; }
        public virtual List<Message> Messages { get; set; }
        public string password { get; set; }
    }
}
