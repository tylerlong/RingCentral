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
        public Subscription Subscription(string _id = null)
        {
            return new Subscription(this, _id);
        }
    }
    public partial class Account
    {
        public Extension Extension(string _id = null)
        {
            return new Extension(this, _id);
        }
        public Order Order(string _id = null)
        {
            return new Order(this, _id);
        }
    }
    public partial class Extension
    {
        public Meeting Meeting(string _id = null)
        {
            return new Meeting(this, _id);
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
        public SecretQuestion SecretQuestion(string _id = null)
        {
            return new SecretQuestion(this, _id);
        }
        public ShippingOption ShippingOption(string _id = null)
        {
            return new ShippingOption(this, _id);
        }
        public Timezone Timezone(string _id = null)
        {
            return new Timezone(this, _id);
        }
    }
}