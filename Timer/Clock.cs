using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    internal class Clock
    {
        public void ParsecTime(int _sec)
        {
            Console.Clear();
            int _minute = _sec / 60;
            int _hour = _minute / 60;
            Console.WriteLine($"{_sec} Sec");
            Console.WriteLine($"{_minute} Min");
            Console.WriteLine($"{_hour} Hour");
        }
    }
}
