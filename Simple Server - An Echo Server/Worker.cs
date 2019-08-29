using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Server___An_Echo_Server
{
    public class Worker
    {
        public void StartSlow()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 7);
            server.Start();

            while (true)
            {
                TcpClient socket = server.AcceptTcpClient(); //venter på client
                DoClient(socket);
            }
        }

        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 7);
            server.Start();

            while (true)
            {
                TcpClient socket = server.AcceptTcpClient(); //venter på client
                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient(tempSocket);
                });
            }
        }

        private void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                string str = sr.ReadLine();
                Thread.Sleep(5000);
                sw.WriteLine(str);
                sw.WriteLine("WordCount: " + WordCount(str));
                sw.Flush();
            }
        }

        public int WordCount(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                string[] strlist = input.Split();

                return strlist.Length;
            }

            return 0;
        }
    }
}
