using System.Threading.Tasks;
using Flurl;

namespace RingCentral
{
    public partial class RestApi
    {
        protected override string Endpoint
        {
            get
            {
                return PathSegment.AppendPathSegment(_id).Path;
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

        internal RestApi(RestClient rc, string _id = "v1.0") : base(null, _id)
        {
            this.rc = rc;
        }

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
