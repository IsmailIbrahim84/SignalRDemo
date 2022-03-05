using Microsoft.AspNetCore.SignalR;

namespace SignalRDemo.HubConfig
{
    public class MyHub : Hub
    {
        public async Task AskServer(string someTextFromClient)
        {
            string tempString;

            if (someTextFromClient == "hey")
            {
                tempString = "Message was 'hey'";
            }
            else
            {

                tempString = "Message was something else";
            }

            await Clients.Clients(this.Context.ConnectionId).SendAsync("AskServerResponse", tempString);

        }
    }
}
