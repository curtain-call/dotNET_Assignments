using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarms
{
    public 

    public delegate void Tick(object sender, );
    public delegate void Alarm();

    public class Alarms
    {
        public event Tick OnTick;
        public event Alarm OnAlarm;
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
