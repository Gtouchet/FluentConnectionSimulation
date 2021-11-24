using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentConnectionSimulation.Interfaces
{
    public interface IFtpDownload
    {
        Stream ToFile(string filePath);
        Stream ToStream(string streamPath);
    }
}
