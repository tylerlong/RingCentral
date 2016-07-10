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
        public RestApi() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "restapi";
            }
        }
    }
}