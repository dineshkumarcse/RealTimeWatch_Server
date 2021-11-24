using Microsoft.AspNetCore.SignalR;
using RealTimeWatch_Server.DataStorage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealTimeCharts_Server.HubConfig
{
    public class WatchHub : Hub
    {
        public async Task Get(string data) => await Clients.All.SendAsync("Get", data + "Get stopwatch......." + WatchManager.GetData());
        public async Task Start(string data) => await Clients.All.SendAsync("Start", data + "Start stopwatch......." + WatchManager.Start());
        public async Task Stop(string data) => await Clients.All.SendAsync("Stop", data + "Stop stopwatch...." + WatchManager.Stop());

    }
}
