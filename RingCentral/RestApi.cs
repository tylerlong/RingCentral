using System.Threading.Tasks;
using Flurl;

namespace RingCentral
{
    public partial class RestApi : Model
    {
        protected override string PathSegment
        {
            get
            {
                return "restapi";
            }
        }

        protected override string Endpoint
        {
            get
            {
                return PathSegment.AppendPathSegment(uriString).Path;
            }
        }

        private RestClient rc;
        protected override RestClient RestClient
        {
            get
            {
                return rc;
            }
        }

        internal RestApi(RestClient rc, string uriString = "v1.0") : base(null, null)
        {
            this.rc = rc;
            this.uriString = uriString;
        }
        public RestApi() : base(null) { }

        public Task<RestApi> Get(object queryParameters = null)
        {
            return RestClient.Get<RestApi>(Endpoint, queryParameters);
        }

        public Task<RestApis> List(object queryParameters = null)
        {
            return RestClient.Get<RestApis>(PathSegment, queryParameters);
        }
    }

    public static class RestApiExtensions
    {
        public static RestApi RestApi(this RestClient rc, string uriString = "v1.0")
        {
            var restApi = new RestApi(rc, uriString);
            return restApi;
        }
    }
}
