using DotNetCoreConfigVault.Client.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DotNetCoreConfigVault.Tests.Client.Concrete
{
    public class SimpleJsonFileConfigurationVaultClientTests
    {
        private string _tempFolder;

        private SimpleJsonFileConfigurationVaultClient _sut;

        public SimpleJsonFileConfigurationVaultClientTests()
        {
            _tempFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            _sut = new SimpleJsonFileConfigurationVaultClient(_tempFolder);
        }

        [Fact]
        public void Basic_save_and_reload()
        {
            var config = new SimpleConfiguration()
            {
                ConfigInt = 42,
                ConfigString = "hello-world"
            };
            _sut.SaveSetting(config);
            var reloaded = _sut.GetSetting<SimpleConfiguration>();

            Assert.Equal(config, reloaded);
        }
    }
}
