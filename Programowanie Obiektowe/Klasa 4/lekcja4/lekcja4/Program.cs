using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Przykład użycia ConfigurationManager
            var config = ConfigurationManager.Instance;
            config.SetSetting("AppName", "My Application");
            Console.ReadKey();
        }
    }

    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private Dictionary<string, object> _settings;
        
        private ConfigurationManager() 
        {
            _settings = new Dictionary<string, object>();
        }
        
        public static ConfigurationManager Instance 
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager();
                }
                return _instance;
            }
        }
        
        public void SetSetting(string key, object value)
        {
            _settings[key] = value;
        }
        
        public T GetSetting<T>(string key, T defaultValue = default)
        {
            if (_settings.TryGetValue(key, out var value) && value is T typedValue)
            {
                return typedValue;
            }
            return defaultValue;
        }
    }
}
