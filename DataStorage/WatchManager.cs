using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RealTimeWatch_Server.DataStorage
{
    public static class WatchManager
    {
        public static Stopwatch time;
        static WatchManager()
        {
            time = new Stopwatch();
        }
        public static string GetData()
        {
            return time.Elapsed.ToString();
        }

        public static string Start()
        {
            time.Start();
            return time.Elapsed.ToString(); ;
        }

        public static string Stop()
        {
            time.Stop();
            return time.Elapsed.ToString(); ;
        }
    }
}
