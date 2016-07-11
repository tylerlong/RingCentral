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
        internal Language(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "language";
            }
        }
    }

    public partial class Language : Model
    {
        public Language() : base(null) { }

        public System.Threading.Tasks.Task<Language> Get(object queryParams = null)
        {
            return Get<Language>(queryParams);
        }
    }
}