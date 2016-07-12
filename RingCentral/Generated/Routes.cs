namespace RingCentral
{
    public partial class RestApi
    {
        public Account Account(string _id = "~")
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
        public Extension Extension(string _id = "~")
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
        public MessageStore MessageStore(string _id = null)
        {
            return new MessageStore(this, _id);
        }
        public PhoneNumber PhoneNumber(string _id = null)
        {
            return new PhoneNumber(this, _id);
        }
        public Grant Grant(string _id = null)
        {
            return new Grant(this, _id);
        }
        public AddressBook AddressBook(string _id = null)
        {
            return new AddressBook(this, _id);
        }
        public AddressBookSync AddressBookSync(string _id = null)
        {
            return new AddressBookSync(this, _id);
        }
        public Favorite Favorite(string _id = null)
        {
            return new Favorite(this, _id);
        }
        public AnsweringRule AnsweringRule(string _id = null)
        {
            return new AnsweringRule(this, _id);
        }
        public BusinessHour BusinessHour(string _id = null)
        {
            return new BusinessHour(this, _id);
        }
        public AuthzProfile AuthzProfile(string _id = null)
        {
            return new AuthzProfile(this, _id);
        }
        public BlockedNumber BlockedNumber(string _id = null)
        {
            return new BlockedNumber(this, _id);
        }
        public ActiveCall ActiveCall(string _id = null)
        {
            return new ActiveCall(this, _id);
        }
        public CallLog CallLog(string _id = null)
        {
            return new CallLog(this, _id);
        }
    }
    public partial class MessageStore
    {
        public Content Content(string _id = null)
        {
            return new Content(this, _id);
        }
    }
    public partial class AddressBook
    {
        public Contact Contact(string _id = null)
        {
            return new Contact(this, _id);
        }
        public Group Group(string _id = null)
        {
            return new Group(this, _id);
        }
    }
    public partial class AuthzProfile
    {
        public Check Check(string _id = null)
        {
            return new Check(this, _id);
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