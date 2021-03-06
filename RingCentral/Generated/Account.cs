namespace RingCentral
{
    public partial class Account
    {
        public string uri;
        public int? id;
        public ServiceInfo serviceInfo;
        public Operator @operator;
        public string mainNumber;
        public string status;
        public SignupInfo signupInfo;
        public string setupWizardState;

        public class ServiceInfo
        {
            public string uri;
            public Brand brand;
            public ServicePlan servicePlan;
            public BillingPlan billingPlan;

            public class Brand
            {
                public string id;
                public string name;
                public HomeCountry homeCountry;

                public class HomeCountry
                {
                    public string id;
                    public string uri;
                    public string name;
                    public string isoCode;
                    public string callingCode;
                }
            }

            public class ServicePlan
            {
                public string id;
                public string name;
                public string edition;
            }

            public class BillingPlan
            {
                public string id;
                public string name;
                public string durationUnit;
                public int? duration;
                public string type;
            }
        }

        public class Operator
        {
            public string uri;
            public int? id;
            public string extensionNumber;
        }

        public class SignupInfo
        {
        }
    }

    public partial class Account : Model
    {
        internal Account(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "account";
            }
        }
    }

    public partial class Account : Model
    {
        public Account() : base(null) { }

        public System.Threading.Tasks.Task<Account> Get(object queryParams = null)
        {
            return Get<Account>(queryParams);
        }
    }
}