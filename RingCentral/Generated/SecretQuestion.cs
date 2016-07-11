namespace RingCentral
{
    public partial class SecretQuestion
    {
        public string uri;
        public int? id;
        public int? questionType;
        public int? languageId;
        public string questionText;
        public bool? showInSignUp;
    }

    public partial class SecretQuestion : Model
    {
        internal SecretQuestion(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "secret-question";
            }
        }
    }

    public partial class SecretQuestion : Model
    {
        public SecretQuestion() : base(null) { }

        public System.Threading.Tasks.Task<SecretQuestion> Get(object queryParams = null)
        {
            return Get<SecretQuestion>(queryParams);
        }
    }
}