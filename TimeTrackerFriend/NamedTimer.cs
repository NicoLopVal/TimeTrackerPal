using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace TimeTrackerFriend
{
    public class NamedTimer
    {
        public string Name { get; set; }
        private double elapsedSeconds = 0;
        private bool isActive = false;

        public NamedTimer(string name)
        {
            this.Name = name;
        }

        public int Hours() => (int)Math.Floor(elapsedSeconds / 3600);

        public int Minutes()
        {
            double currentElapsed = elapsedSeconds;
            currentElapsed -= Hours() * 3600;
            return (int)Math.Floor(currentElapsed / 60);
        }

        public int Seconds() => (int)(elapsedSeconds - (Hours() * 3600) - (Minutes() * 60));

        public int TotalSeconds() =>(int)elapsedSeconds;

        public void AddSeconds(double seconds)
        {
            elapsedSeconds += seconds;
        }

        public void Tick()
        {
            if(isActive)
                elapsedSeconds += 1;
        }

        public void Start()
        {
            isActive = true;
        }

        public void Stop()
        {
            isActive = false;
        }

        public void Reset()
        {
            elapsedSeconds = 0;
            isActive = false;
        }

        public string GetFormattedElapsed()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", Hours(), Minutes(), Seconds());
        }

    }
}
