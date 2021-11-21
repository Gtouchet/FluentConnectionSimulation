using FluentConnectionSimulation.Dtos;
using FluentConnectionSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentConnectionSimulation.Implementations
{
    public sealed class Ftp : IFtpTransfer, IFtpDownload, IFtpUpload
    {
        private string FtpUrl;
        private Credentials Credentials;
        private string FileName;

        private Ftp(string ftpUrl, Credentials credentials)
        {
            this.FtpUrl = ftpUrl;
            this.Credentials = credentials;
        }

        private Ftp(Ftp prototype)
        {
            this.FtpUrl = prototype.FtpUrl;
            this.Credentials = prototype.Credentials;
        }

        public static IFtpTransfer Connect(string ftpUrl, Credentials credentials)
        {
            Console.WriteLine($"Connected to FTP {ftpUrl} with credentials {credentials}");
            return new Ftp(ftpUrl, credentials);
        }

        public IFtpDownload Download(string fileName)
        {
            Console.WriteLine($"Attempting to download {fileName}");
            Ftp clone = new Ftp(this);
            clone.FileName = fileName;
            return clone;
        }

        public IFtpUpload Upload(string fileName)
        {
            Console.WriteLine($"Attempting to upload {fileName}");
            Ftp clone = new Ftp(this);
            clone.FileName = fileName;
            return clone;
        }

        public void ToFile(string filePath)
        {
            Console.WriteLine($"File {filePath} downloaded\n");
        }

        public void ToStream(Stream stream)
        {
            Console.WriteLine($"Stream {stream} downloaded\n");
        }

        public void FromFile(string filePath)
        {
            Console.WriteLine($"File {filePath} uploaded\n");
        }

        public void FromStream(Stream stream)
        {
            Console.WriteLine($"Stream {stream} uploaded\n");
        }
    }
}
