using Microsoft.AspNetCore.SignalR.Client;

var connection = new HubConnectionBuilder()
    .WithUrl("http://localhost:5000/signalR/hub")
    .Build();

connection.StartAsync().Wait();

connection.On("recieveMessege", (string username, string message) =>
{
    Console.WriteLine(username + ':' + message);
    Console.ReadKey();
});

connection.InvokeCoreAsync("sendMessege", args: new[] { "Csfreak", "Hello!" });