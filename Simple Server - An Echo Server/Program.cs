using System;

namespace Simple_Server___An_Echo_Server
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
