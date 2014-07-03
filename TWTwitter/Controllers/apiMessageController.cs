using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TWTwitter.Adapters.Adapters;
using TWTwitter.Adapters.Interfaces;
using TWTwitter.Data.Models;

namespace TWTwitter.Controllers
{
    public class apiMessageController : ApiController
    {
        private IMessage _messageAdapter;
        public apiMessageController()
        {
            _messageAdapter = new MessageAdapter();
        }
        public IHttpActionResult Get(string id)
        {
            return Ok(_messageAdapter.GetMessages(id));
        }
        public IHttpActionResult Post(Message message)
        {
            _messageAdapter.SendMessage(message);
            return Ok();
        }
    }
}
