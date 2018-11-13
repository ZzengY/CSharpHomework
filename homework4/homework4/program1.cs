using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class TimeArgs : EventArgs
    {
        public int hour;
        public int minute;
        public int second;
    }
    public delegate void AlarmHandler(object sender, TimeArgs e);

    public class AlarmTime
    {
        public event AlarmHandler RunTime;
        public void ThisTime(TimeArgs args)
        {
            while (true)
            {
                if (args.hour == DateTime.Now.Hour && args.minute == DateTime.Now.Minute && args.second == DateTime.Now.Second)
                {
                    RunTime(this, args);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
    public class AlarmRing
    {
        static void Main()
        {
            TimeArgs args = new TimeArgs();
            args.hour = 22;
            args.minute = 01;
            args.second = 20;
            var alarmtime = new AlarmTime();
            alarmtime.RunTime += IfTime;
            alarmtime.ThisTime(args);
        }

        static void IfTime(object sender, TimeArgs e)
        {                           
                    System.Console.WriteLine("alarm clock ring!");                               
        }
    }
}
