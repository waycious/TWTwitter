﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TWTwitter.Data.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public string TargetId { get; set; }
    }
}
