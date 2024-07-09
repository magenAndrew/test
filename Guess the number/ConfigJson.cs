using Microsoft.Extensions.Configuration;

namespace Guess_the_number
{
    public class ConfigJson : IConfig
    {
        private readonly IConfiguration _configuration;
        public ConfigJson() {
            _configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .AddEnvironmentVariables()
        .Build();
          
        }
        int IConfig.AttempCount => _configuration.GetValue<int>("AttempCount");

        int IConfig.MaxValue => _configuration.GetValue<int>("MaxValue");

        int IConfig.MinValue => _configuration.GetValue<int>("MinValue");
    }
}
