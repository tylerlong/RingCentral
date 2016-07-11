namespace RingCentral
{
    public partial class RestApis
    {
        public string uri;
        public ApiVersion[] apiVersions;
        public string serverVersion;
        public string serverRevision;

        public class ApiVersion
        {
            public string uri;
            public string versionString;
            public string releaseDate;
            public string uriString;
        }
    }

    public partial class RestApi
    {
        public System.Threading.Tasks.Task<RestApis> List(object queryParams = null)
        {
            return List<RestApis>(queryParams);
        }
    }
}