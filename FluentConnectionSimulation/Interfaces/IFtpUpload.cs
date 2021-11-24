using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentConnectionSimulation.Interfaces
{
    public interface IFtpUpload
    {
        void FromFile(string filePath);
        void FromStream(string streamPath);
    }
}
