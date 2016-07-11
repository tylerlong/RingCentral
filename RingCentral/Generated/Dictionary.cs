namespace RingCentral
{
    public partial class Dictionary
    {
    }

    public partial class Dictionary : Model
    {
        internal Dictionary(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "dictionary";
            }
        }
    }
}