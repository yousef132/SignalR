using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        public void sendMessage(string name, string inputMessage)
        {


            // save in db 
            // do some logic 
            Clients.All.newMessage(name, inputMessage);
        }

        public void joinGroup(string groupName, string clientName)
        {
            // add client to group
            Groups.Add(Context.ConnectionId, groupName);

            // invoke the event to all other client in the same group
            Clients.OthersInGroup(groupName).joinGroup(clientName, groupName);
        }

        public void sendGroup(string groupName, string clientName, string message)
        {
            Clients.Group(groupName).sendGroup(clientName, message);
        }

    }
}