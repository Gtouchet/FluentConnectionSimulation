using FluentConnectionSimulation.Dtos;
using FluentConnectionSimulation.Implementations;
using System;
using System.IO;

namespace FluentConnectionSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ftp.Connect("ftp://192.168.0.1/", new Credentials() { User = "GTouchet", Password = "1234" })
                .Download("/pictures/myPhoto")
                .ToFile("C:/Documents/Images/myPhoto");

            Ftp.Connect("ftp://145.17.119.201/", new Credentials() { User = "Anonymous", Password = "unknown" })
                .Upload("/videos/myVideo")
                .FromStream(Stream.Null);
        }
    }
}
