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
    public class MessageAdapter : IMessage
    {

        public List<MessageVM> GetMessages(string userId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return db.Messages.Where(
                m => m.TargetId == userId).Select(
                m => new MessageVM 
                {
                    Id = m.Id,
                    Subject = m.Subject,
                    Text = m.Text,
                    TargetId = m.TargetId,
                    UserId = m.UserId
                }).ToList();
        }

        public void SendMessage(Message message)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Messages.Add(message);
            db.SaveChanges();
        }
    }
}