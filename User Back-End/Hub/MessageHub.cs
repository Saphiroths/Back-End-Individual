using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Back_End.Hubs
{
    public class MessageHub : Hub
    {
    
        public async Task askServer(string message)
        {
            string tempstring;

            if (message == "hey")
            {
                tempstring = "message was 'hey'";
            }
            else
            {
                tempstring = "no message";
            }

            await Clients.Clients(this.Context.ConnectionId).SendAsync("askServerResponse", tempstring);
        }
    }
}
