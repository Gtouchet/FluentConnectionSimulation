using FluentConnectionSimulation.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentConnectionSimulation.Interfaces
{
    public interface IFtpTransfer
    {
        IFtpDownload Download(string filePath);
        IFtpUpload Upload(string filePath);
    }
}
