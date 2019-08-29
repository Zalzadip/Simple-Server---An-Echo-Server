﻿using System;
using System.IO;
using System.Net.Sockets;

namespace EchoClient
{
    class Worker
    {
        public void Start()
        {
            using (TcpClient socket = new TcpClient("localhost", 7))
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                string str = "Den besked jeg sender";
                sw.WriteLine(str);
                sw.Flush();

                string strin = sr.ReadLine();
                Console.WriteLine(strin);
            }
        }
    }
}