using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace RingCentral
{
    public class RestClient
    {
        public const string SandboxServer = "https://platform.devtest.ringcentral.com";
        public const string ProductionServer = "https://platform.ringcentral.com";

        public string appKey;
        public string appSecret;
        public string server;
        private Token _token;
        private bool refreshScheduled = false;
        public Token token
        {
            get
            {
                return _token;
            }
            set
            {
                _token = value;
                if (_token != null)
                {
                    if (!refreshScheduled)
                    { // don't do duplicate schedule
                        TaskEx.Delay((_token.expires_in.Value - 120) * 1000).ContinueWith((action) =>
                        { // 2 minutes before expiration
                            refreshScheduled = false;
                            Refresh();
                        });
                        refreshScheduled = true;
                    }
                }
            }
        }

        public RestClient(string appKey, string appSecret, string server)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.server = server;
        }
        public RestClient(string appKey, string appSecret, bool production = false) : this(appKey, appSecret, production ? ProductionServer : SandboxServer)
        {
        }

        public void Authorize(string username, string extension, string password)
        {
            var url = new Url(server).AppendPathSegment("/restapi/oauth/token");
            var client = url.WithBasicAuth(appKey, appSecret);
            var requestBody = new { username = username, extension = extension, password = password, grant_type = "password" };
            token = client.PostUrlEncodedAsync(requestBody).ReceiveJson<Token>().Result;
        }

        private void Refresh()
        {
            if (token == null)
            {
                return;
            }
            var url = new Url(server).AppendPathSegment("/restapi/oauth/token");
            var client = url.WithBasicAuth(appKey, appSecret);
            var requestBody = new { grant_type = "refresh_token", refresh_token = token.refresh_token, endpoint_id = token.endpoint_id };
            token = client.PostUrlEncodedAsync(requestBody).ReceiveJson<Token>().Result;
        }
    }
}
