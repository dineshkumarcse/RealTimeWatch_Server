using Microsoft.AspNetCore.SignalR;
using RealTimeWatch_Server.DataStorage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealTimeWatch_Server.HubConfig
{
    public class WatchHub : Hub
    {
        public async Task Get(string data) => await Clients.All.SendAsync("Get", "Get stopwatch......." + WatchManager.GetData());
        public async Task Start(string data) => await Clients.All.SendAsync("Start", "Start stopwatch......." + WatchManager.Start());
        public async Task Stop(string data) => await Clients.All.SendAsync("Stop", "Stop stopwatch...." + WatchManager.Stop());

    }
}
