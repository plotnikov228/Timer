using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            Clock clock = new Clock();

            timer.TimeChangeEvent += clock.ParsecTime;

            timer.Start();
        }
    }
}
