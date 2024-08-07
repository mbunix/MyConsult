using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myconsult.Identity.Helper
{
    public class IdentitySettings
    {
        public bool Enabled { get; set; }
        public string Secrets { get; set; }
        public string SharedSecret { get; set; }

    }
}