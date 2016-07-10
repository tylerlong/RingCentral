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
        public Contact() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "contact";
            }
        }
    }
}