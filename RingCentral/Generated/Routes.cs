namespace RingCentral
{
    public partial class RestApi
    {
        public Account Account(string _id = null)
        {
            return new Account(this, _id);
        }
        public Dictionary Dictionary(string _id = null)
        {
            return new Dictionary(this, _id);
        }
    }
    public partial class Account
    {
        public Extension Extension(string _id = null)
        {
            return new Extension(this, _id);
        }
    }
    public partial class Dictionary
    {
        public Language Language(string _id = null)
        {
            return new Language(this, _id);
        }
        public State State(string _id = null)
        {
            return new State(this, _id);
        }
        public Country Country(string _id = null)
        {
            return new Country(this, _id);
        }
        public Location Location(string _id = null)
        {
            return new Location(this, _id);
        }
    }
}