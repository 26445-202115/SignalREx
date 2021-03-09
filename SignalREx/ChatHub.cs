using Microsoft.AspNetCore.SignalR;
using SignalREx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalREx
{
    public class ChatHub:Hub
    {
        public async Task SendAllMessage(string userName, string textMessage)
        {
            var message = new ChatMessage
            {
                UserName = userName,
                Message = textMessage,
                TimeStamp = DateTimeOffset.Now
            };

            await Clients.All.SendAsync("ReceiveMessage",message.UserName, message.TimeStamp,message.Message);
        }
    }
}
