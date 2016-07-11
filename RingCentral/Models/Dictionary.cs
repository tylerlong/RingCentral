namespace RingCentral
{
    public partial class Dictionary : Model
    {
        internal Dictionary(Model parent, string _id = null) : base(parent) { }

        protected override string PathSegment
        {
            get
            {
                return "dictionary";
            }
        }
    }
}