namespace RingCentral
{
    public partial class Language
    {
        public string uri;
        public string id;
        public string name;
        public string isoCode;
        public string localeCode;
        public bool? ui;
        public bool? greeting;
        public bool? formattingLocale;
    }

    public partial class Language : Model
    {
        public Language() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "language";
            }
        }
    }
}