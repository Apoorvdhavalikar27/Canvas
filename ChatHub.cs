using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingleRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            string connectionId = Context.ConnectionId;
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
            //Clients.All.broadcastMessage(connectionId, name, message);
           
        }

    }
}