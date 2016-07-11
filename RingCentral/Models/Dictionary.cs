namespace RingCentral
{
    public class Dictionary : Model
    {
        internal Dictionary(Model parent) : base(parent) { }

        protected override string PathSegment
        {
            get
            {
                return "dictionary";
            }
        }
    }

    public static class DictionaryExtensions
    {
        public static Dictionary Dictionary(this RestApi restApi)
        {
            return new Dictionary(restApi);
        }
    }
}