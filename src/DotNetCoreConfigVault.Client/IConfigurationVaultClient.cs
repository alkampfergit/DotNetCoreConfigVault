using System;

namespace DotNetCoreConfigVault.Client
{
    /// <summary>
    /// Simple client for a configuration vault that directly
    /// store objects inside some configuration storage.
    /// </summary>
    public interface IConfigurationVaultClient
    {
        T GetSetting<T>() where T : new();

        void SaveSetting<T>(T setting) where T : new();
    }
}
