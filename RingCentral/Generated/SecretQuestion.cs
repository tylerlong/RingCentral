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