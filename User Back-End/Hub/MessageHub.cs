﻿using Microsoft.AspNetCore.SignalR;
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

            //string tempstring;

            //if (message == "You are logged in!")
            //{
            //    tempstring = "You are logged in!";
            //}
            //else
            //{
            //    tempstring = "no message";
            //}

            await Clients.All.SendAsync("askServerResponse", message);
        }

    }
}
