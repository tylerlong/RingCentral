namespace RingCentral
{
    public partial class ShippingOption
    {
    }

    public partial class ShippingOption : Model
    {
        internal ShippingOption(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "shippingoption";
            }
        }
    }
}