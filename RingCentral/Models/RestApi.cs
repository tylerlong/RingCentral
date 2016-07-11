using System.Threading.Tasks;

namespace RingCentral
{
    public partial class RestApi
    {
        public Task<RestApis> List(object queryParams = null)
        {
            return List<RestApis>(queryParams);
        }
    }

    public static class RestApiExtensions
    {
        public static RestApi RestApi(this RestClient rc, string uriString = "v1.0")
        {
            var restApi = new RestApi(new MockModel(rc), uriString);
            return restApi;
        }
    }
}