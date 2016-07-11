namespace RingCentral
{
    public partial class AnsweringRule
    {
        public string uri;
        public string id;
        public string type;
        public bool? enabled;
        public string callHandlingAction;
        public Forwarding forwarding;
        public Voicemail voicemail;
        public Greeting[] greetings;

        public class Forwarding
        {
            public bool? notifyMySoftPhones;
            public bool? notifyAdminSoftPhones;
            public int? softPhonesRingCount;
            public string ringingMode;
        }

        public class Voicemail
        {
            public bool? enabled;
            public Recipient recipient;

            public class Recipient
            {
                public string uri;
                public int? id;
            }
        }

        public class Greeting
        {
            public string type;
            public Preset preset;

            public class Preset
            {
                public string uri;
                public string id;
                public string name;
            }
        }
    }

    public partial class AnsweringRule : Model
    {
        internal AnsweringRule(Model parent, string _id = null) : base(parent, _id) { }
        public AnsweringRule() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "answeringrule";
            }
        }

        public System.Threading.Tasks.Task<AnsweringRule> Get(object queryParams = null)
        {
            return Get<AnsweringRule>(queryParams);
        }
    }

}