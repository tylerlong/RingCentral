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

        protected override string PathSegment
        {
            get
            {
                return "blockednumber";
            }
        }
    }

    public partial class BlockedNumber : Model
    {
        public BlockedNumber() : base(null) { }

        public System.Threading.Tasks.Task<BlockedNumber> Get(object queryParams = null)
        {
            return Get<BlockedNumber>(queryParams);
        }
    }
}