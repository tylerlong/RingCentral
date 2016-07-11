namespace RingCentral
{
    public partial class Timezone
    {
        public string uri;
        public string id;
        public string name;
        public string description;
    }

    public partial class Timezone : Model
    {
        internal Timezone(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "timezone";
            }
        }
    }

    public partial class Timezone : Model
    {
        public Timezone() : base(null) { }

        public System.Threading.Tasks.Task<Timezone> Get(object queryParams = null)
        {
            return Get<Timezone>(queryParams);
        }
    }
}