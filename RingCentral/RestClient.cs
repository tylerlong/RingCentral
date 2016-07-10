using Flurl;
using Flurl.Http;

namespace RingCentral
{
    public class RestClient
    {
        const string SandboxServer = "https://platform.devtest.ringcentral.com";
        const string ProductionServer = "https://platform.ringcentral.com";

        string appKey;
        string appSecret;
        private bool _sandbox;
        bool sandbox
        {
            set
            {
                _sandbox = value;
                server = _sandbox ? SandboxServer : ProductionServer;
            }
        }
        string server;

        public RestClient(string appKey, string appSecret, bool sandbox = true)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.sandbox = sandbox;
        }
        public RestClient(string appKey, string appSecret, string server)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.server = server;
        }

        public Token Token;
        public void Login(string username, string extension, string password)
        {
            var url = new Url(server).AppendPathSegment("/restapi/oauth/token");
            var client = url.WithBasicAuth(appKey, appSecret);
            var requestBody = new { username = username, extension = extension, password = password, grant_type = "password" };
            Token = client.PostUrlEncodedAsync(requestBody).ReceiveJson<Token>().Result;
        }
    }
}
