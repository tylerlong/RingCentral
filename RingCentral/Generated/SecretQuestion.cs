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
        public SecretQuestion() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "secretquestion";
            }
        }
    }
}