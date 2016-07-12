namespace RingCentral
{
    public partial class AddressBook
    {
    }

    public partial class AddressBook : Model
    {
        internal AddressBook(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "address-book";
            }
        }
    }
}