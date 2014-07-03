using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TWTwitter.Models
{
    public class MessageVM
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public string TargetId { get; set; }
    }
}