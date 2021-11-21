using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentConnectionSimulation.Dtos
{
    public class Credentials
    {
        public string User { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"user: [{this.User}], password: [{this.Password}]";
        }
    }
}
