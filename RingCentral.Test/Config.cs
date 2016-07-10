using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;

namespace RingCentral.Test
{
    public partial class Config
    {
        private static Config instance = null;
        private Config() { }

        internal static Config Instance
        {
            get
            {
                if (instance == null)
                {
                    using (var sr = new StreamReader(
                        Path.Combine(TestContext.CurrentContext.TestDirectory, "config.json")))
                    {
                        var jsonData = sr.ReadToEnd();
                        instance = JsonConvert.DeserializeObject<Config>(jsonData);
                    }
                }
                return instance;
            }
        }
    }

    public partial class Config
    {
        public bool? sandbox;
        public string server;
        public string appKey;
        public string appSecret;
        public string username;
        public string extension;
        public string password;
    }
}
