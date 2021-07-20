using System;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMessanger
{
    public class MessageHub : Hub
    {
        public Task SendMessage(string textMessage)
        {
            return Clients.Others.SendAsync("SendMessage", textMessage);
        }




    }
}

