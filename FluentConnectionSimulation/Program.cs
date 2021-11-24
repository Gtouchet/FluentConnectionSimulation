using FluentConnectionSimulation.Dtos;
using FluentConnectionSimulation.Implementations;
using FluentConnectionSimulation.Interfaces;
using System;
using System.IO;

namespace FluentConnectionSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            IFtpTransfer ftp = Ftp.Connect("ftp://192.168.0.1/", new Credentials() { User = "GTouchet", Password = "1234" });

            ftp.Download("/pictures/myPhoto").ToFile("C:/Documents/Images/myPhoto");
            ftp.Upload("/videos/myVideo").FromStream("C:/Documents/Videos/myVideo");

            Stream downloadedStream = Ftp.Connect("ftp://100.50.0.1/", new Credentials() { User = "GTouchet", Password = "abcd" })
                .Download("/pictures/myPhoto")
                .ToStream("C:/Documents/Images/myPhoto");
        }
    }
}
