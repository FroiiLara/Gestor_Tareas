using System;
using System.Timers;
using System.Threading;
namespace Gestor_Tareas.Models
{
    public class TimerService
    {
        private System.Timers.Timer _timer;

        public event Action<string> DateUpdated;

        public TimerService()
        {
            _timer = new System.Timers.Timer(60000);
            _timer.Elapsed += (sender, e) => UpdateDate();
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void UpdateDate()
        {
            DateUpdated?.Invoke(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
        }
    }
}

