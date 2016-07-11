namespace RingCentral
{
    public partial class RestApi
    {
        public string uri;
        public string versionString;
        public string releaseDate;
        public string uriString;
    }

    public partial class RestApi : Model
    {
        internal RestApi(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "restapi";
            }
        }
    }

    public partial class RestApi : Model
    {
        public RestApi() : base(null) { }

        public System.Threading.Tasks.Task<RestApi> Get(object queryParams = null)
        {
            return Get<RestApi>(queryParams);
        }
    }
}