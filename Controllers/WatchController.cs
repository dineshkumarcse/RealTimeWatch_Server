using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RealTimeCharts_Server.HubConfig;
using RealTimeWatch_Server.DataStorage;
using RealTimeWatch_Server.TimerFeatures;

namespace RealTimeWatch_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchController : ControllerBase
    {
        private IHubContext<WatchHub> _hub;

        public WatchController(IHubContext<WatchHub> hub)
        {
            _hub = hub;
        }

        public IActionResult Get()
        {
            var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("WatchData", WatchManager.GetData()));

            return Ok(new { Message = WatchManager.GetData() + "Request Completed" });
        }

        [Route("Start")]
        public IActionResult Start()
        {
            WatchManager.Start();

            return Ok(new { Message = "Request Completed" });
        }

        [Route("Stop")]

        public IActionResult Stop()
        {
            WatchManager.Stop();

            return Ok(new { Message = "Request Completed" });
        }
    }
}