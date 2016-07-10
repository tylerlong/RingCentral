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
        public Timezone() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "timezone";
            }
        }
    }
}