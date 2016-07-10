namespace RingCentral
{
    public partial class BlockedNumber
    {
        public string uri;
        public string id;
        public string phoneNumber;
        public string name;
    }

    public partial class BlockedNumber : Model
    {
        internal BlockedNumber(Model parent, string _id = null) : base(parent, _id) { }
        public BlockedNumber() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "blockednumber";
            }
        }
    }
}