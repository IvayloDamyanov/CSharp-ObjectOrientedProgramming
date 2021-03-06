﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    public class VersionAttribute : Attribute
    {
        private string version;

        public string Version
        {
            get
            {
                return this.version;
            }
            private set
            {
                this.version = value;
            }
        }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}
