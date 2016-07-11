namespace RingCentral
{
    public partial class Contact
    {
        public string uri;
        public string availability;
        public int? id;
        public string firstName;
        public string lastName;
        public string homePhone;
        public string businessPhone;
        public string mobilePhone;
    }

    public partial class Contact : Model
    {
        internal Contact(Model parent, string _id = null) : base(parent, _id) { }
        public Contact() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "contact";
            }
        }

        public System.Threading.Tasks.Task<Contact> Get(object queryParams = null)
        {
            return Get<Contact>(queryParams);
        }
    }

}