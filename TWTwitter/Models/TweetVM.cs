using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TWTwitter.Models
{
    public class TweetVM
    {
        public int Id { get; set; }
        public String Text { get; set; }
        public String UserId { get; set; }
        public String TargetId { get; set; }
    }
}