namespace RingCentral
{
    public partial class Token
    {
        public string access_token;
        public string token_type;
        public int? expires_in;
        public string refresh_token;
        public int? refresh_token_expires_in;
        public string scope;
        public string owner_id;
        public string endpoint_id;
    }

    public partial class Token : Model
    {
        internal Token(Model parent, string _id = null) : base(parent, _id) { }
        public Token() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "token";
            }
        }
    }
}