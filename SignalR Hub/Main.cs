using Microsoft.AspNetCore.SignalR;

namespace SignalR_Hub;

internal class Main : Hub
{
    public async Task sendMessege(string username,string message)
    {
        await Clients.All.SendAsync("recieveMessege",username,message);
    }
}

