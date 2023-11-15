using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace shambalaWpfWorkReestr_11_11_2023
{
    public class Timer
    {
        public Timer(TimerCallback tm, int num, int v1, int v2)
        {
        }

        public string timerTick { get; set; }
        public string UserTimer()
        {
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

            timer.Start ();
            string timerValue = timer.Tag as string;
            return timerValue;

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
