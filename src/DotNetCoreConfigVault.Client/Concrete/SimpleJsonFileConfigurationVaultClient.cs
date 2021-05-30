using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DotNetCoreConfigVault.Client.Concrete
{
    public class SimpleJsonFileConfigurationVaultClient : IConfigurationVaultClient
    {
        private readonly string _configurationFolder;

        public SimpleJsonFileConfigurationVaultClient(string configurationFolder)
        {
            _configurationFolder = configurationFolder;
            if (!Directory.Exists(_configurationFolder))
            {
                Directory.CreateDirectory(_configurationFolder);
            }
        }

        public T GetSetting<T>() where T : new()
        {
            var file = GetConfigFileName<T>();
            if (!File.Exists(file))
            {
                return new T();
            }
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }

        public void SaveSetting<T>(T setting) where T : new()
        {
            var fileName = GetConfigFileName<T>();
            var serialized = JsonConvert.SerializeObject(setting);
            File.WriteAllText(fileName, serialized);
        }

        private string GetConfigFileName<T>() where T : new()
        {
            return Path.ChangeExtension( Path.Combine(_configurationFolder, typeof(T).Name), ".json");
        }
    }

    public class SimpleJsonFileConfigurationVaultClientFactory 
    {
        
    }
}
