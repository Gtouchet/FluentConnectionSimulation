using FluentConnectionSimulation.Dtos;
using FluentConnectionSimulation.Interfaces;
using System;
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
        private string FilePath;

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

        public IFtpDownload Download(string filePath)
        {
            Console.WriteLine($"Attempting to download {filePath}");
            Ftp clone = new Ftp(this);
            clone.FilePath = filePath;
            return clone;
        }

        public IFtpUpload Upload(string filePath)
        {
            Console.WriteLine($"Attempting to upload {filePath}");
            Ftp clone = new Ftp(this);
            clone.FilePath = filePath;
            return clone;
        }

        public Stream ToFile(string filePath)
        {
            Console.WriteLine($"File {filePath} downloaded\n");
            return File.Create(filePath);
        }

        public Stream ToStream(string streamPath)
        {
            Console.WriteLine($"Stream {streamPath} downloaded\n");
            return Stream.Null;
        }

        public void FromFile(string filePath)
        {
            Console.WriteLine($"File {filePath} uploaded\n");
        }

        public void FromStream(string streamPath)
        {
            Console.WriteLine($"Stream {streamPath} uploaded\n");
        }
    }
}
