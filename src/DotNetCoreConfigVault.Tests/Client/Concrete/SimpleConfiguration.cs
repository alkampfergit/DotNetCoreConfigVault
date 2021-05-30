using System;

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
            return (ConfigString?.GetHashCode() ?? 23) * 17 + this.ConfigInt.GetHashCode();
        }
    }
}
