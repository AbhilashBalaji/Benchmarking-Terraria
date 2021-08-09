﻿using System;
using System.Net;
using TrClient;

namespace TrClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TClient();
            client.CurRelease = "Terraria238";

            client.OnChat += (o, t, c) => Console.WriteLine(t);

            client.GameLoop(new IPEndPoint(IPAddress.Loopback, 7777), null);
        }
    }
}