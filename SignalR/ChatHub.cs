using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        public void sendMessage(string name, string message)
        {
            Clients.Others.newMessage(name, message);
        }

    }
}