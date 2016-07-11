namespace RingCentral
{
    public partial class State
    {
        public string uri;
        public string id;
        public string name;
        public string isoCode;
        public Country country;

        public class Country
        {
            public string uri;
            public string id;
        }
    }

    public partial class State : Model
    {
        internal State(Model parent, string _id = null) : base(parent, _id) { }
        public State() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "state";
            }
        }

        public System.Threading.Tasks.Task<State> Get(object queryParams = null)
        {
            return Get<State>(queryParams);
        }
    }

}