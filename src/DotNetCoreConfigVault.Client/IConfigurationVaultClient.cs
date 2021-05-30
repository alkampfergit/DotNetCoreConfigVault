using System;

namespace DotNetCoreConfigVault.Client
{
    public interface IConfigurationVaultClient
    {
        T GetSetting<T>();

        void SaveSetting<T>();
    }
}
