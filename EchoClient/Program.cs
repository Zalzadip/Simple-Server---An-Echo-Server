﻿using System;

namespace EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Start();

            Console.ReadKey();
        }
    }
}
