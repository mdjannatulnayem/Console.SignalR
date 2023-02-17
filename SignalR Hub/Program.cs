using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using SignalR_Hub;

GetWebHostbuilder(args).Build().Run();

static IWebHostBuilder GetWebHostbuilder(string[] args)
{
    return WebHost.CreateDefaultBuilder(args)
    .UseStartup<Startup>();
}


