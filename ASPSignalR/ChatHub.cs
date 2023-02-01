using Microsoft.AspNetCore.SignalR;

namespace SignalRTest
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string username, string email)
        {
            await this.Clients.All.SendAsync("Receive", message, username, email);
        }
    }
}
