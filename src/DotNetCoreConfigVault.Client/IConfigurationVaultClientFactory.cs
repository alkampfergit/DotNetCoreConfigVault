using System;

namespace DotNetCoreConfigVault.Client
{
    /// <summary>
    /// An helper class that abstract the creation of a
    /// <see cref="IConfigurationVaultClient"/> object
    /// based on a configuration string.
    /// </summary>
    public class ConfigurationVaultClientFactory
    {
        /// <summary>
        /// Create a <see cref="IConfigurationVaultClient"/> based
        /// on a connectionInfo string stored somewhere. Each different
        /// vault client will use a different string format for
        /// configuration.
        /// <returns>An insance of <see cref="IConfigurationVaultClient"/> or
        /// nothing if this factoy does not understand the connectionInfo string.</returns>
        IConfigurationVaultClient Create(string connectionInfo) 
        {
            throw new NotImplementedException();
        }
    }
}
