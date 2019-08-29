using System;
using System.ComponentModel;

namespace DemoDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Start();
        }
    }
}
