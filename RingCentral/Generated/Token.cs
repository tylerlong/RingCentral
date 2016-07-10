namespace RingCentral
{
    public partial class Token
    {
        public string token_type;
        public string access_token;
        public int? expires_in;
        public string refresh_token;
        public int? refresh_token_expires_in;
        public string scope;
        public string owner_id;
        public string endpoint_id;
        public double? expire_time;
        public double? refresh_token_expire_time;
    }
}