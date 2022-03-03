using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    internal class Timer
    {
        public delegate void TimeChange(int sec);   
        public event TimeChange TimeChangeEvent;
        
      
        public void Start()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1000);
                TimeChangeEvent.Invoke(i);
                
                
            }
        }
    }
}
