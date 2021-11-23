using System;
using System.Threading;

namespace RealTimeWatch_Server.TimerFeatures
{
    public class TimerManager
    {
        private Timer _timer;
        private AutoResetEvent _autoResetEvent;
        private Action _action;

        public DateTime TimerStarted { get; }

        public TimerManager(Action action)
        {
            _action = action;
            _autoResetEvent = new AutoResetEvent(false);
            _timer = new Timer(Execute, _autoResetEvent, 100, 200);
            TimerStarted = DateTime.Now;
        }

        public void Execute(object stateInfo)
        {
            _action();

            if((DateTime.Now - TimerStarted).Seconds > 60)
            {
                _timer.Dispose();
            }
        }
    }
}
