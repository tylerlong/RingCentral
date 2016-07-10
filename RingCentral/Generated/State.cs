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
}