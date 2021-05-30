using System;
using System.Collections.Generic;

namespace DotNetCoreConfigVault.Tests.Client.Concrete
{
    public class SimpleConfiguration
    {
        public String ConfigString { get; set; }

        public Int32 ConfigInt { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SimpleConfiguration configuration &&
                   ConfigString == configuration.ConfigString &&
                   ConfigInt == configuration.ConfigInt;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ConfigString, ConfigInt);
        }

        public static bool operator ==(SimpleConfiguration left, SimpleConfiguration right)
        {
            return EqualityComparer<SimpleConfiguration>.Default.Equals(left, right);
        }

        public static bool operator !=(SimpleConfiguration left, SimpleConfiguration right)
        {
            return !(left == right);
        }
    }
}
