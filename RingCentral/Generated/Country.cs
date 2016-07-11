namespace RingCentral
{
    public partial class Country
    {
        public string uri;
        public string id;
        public string name;
        public string isoCode;
        public string callingCode;
        public bool? emergencyCalling;
        public bool? numberSelling;
        public bool? loginAllowed;
    }

    public partial class Country : Model
    {
        internal Country(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "country";
            }
        }
    }

    public partial class Country : Model
    {
        public Country() : base(null) { }

        public System.Threading.Tasks.Task<Country> Get(object queryParams = null)
        {
            return Get<Country>(queryParams);
        }
    }
}