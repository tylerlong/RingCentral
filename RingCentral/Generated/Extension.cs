namespace RingCentral
{
    public partial class Extension
    {
        public string uri;
        public int? id;
        public string extensionNumber;
        public Contact contact;
        public string name;
        public string type;
        public string status;
        public ServiceFeature[] serviceFeatures;
        public RegionalSettings regionalSettings;
        public string setupWizardState;
        public Permissions permissions;
        public ProfileImage profileImage;
        public Department[] departments;

        public class Contact
        {
            public string firstName;
            public string lastName;
            public string company;
            public string email;
            public string businessPhone;
            public BusinessAddress businessAddress;
            public string department;

            public class BusinessAddress
            {
                public string street;
                public string city;
                public string zip;
                public string country;
                public string state;
            }
        }

        public class ServiceFeature
        {
            public string featureName;
            public bool? enabled;
            public string reason;
        }

        public class RegionalSettings
        {
            public Timezone timezone;
            public HomeCountry homeCountry;
            public Language language;
            public GreetingLanguage greetingLanguage;
            public FormattingLocale formattingLocale;
            public string timeFormat;

            public class Timezone
            {
                public string uri;
                public string id;
                public string name;
                public string description;
            }

            public class HomeCountry
            {
                public string uri;
                public string id;
                public string name;
                public string isoCode;
                public string callingCode;
            }

            public class Language
            {
                public string id;
                public string name;
                public string localeCode;
            }

            public class GreetingLanguage
            {
                public string id;
                public string name;
                public string localeCode;
            }

            public class FormattingLocale
            {
                public string id;
                public string name;
                public string localeCode;
            }
        }

        public class Permissions
        {
            public Admin admin;
            public InternationalCalling internationalCalling;

            public class Admin
            {
                public bool? enabled;
            }

            public class InternationalCalling
            {
                public bool? enabled;
            }
        }

        public class ProfileImage
        {
            public string uri;
            public string etag;
            public string contentType;
            public string lastModified;
            public Scale[] scales;

            public class Scale
            {
                public string uri;
            }
        }

        public class Department
        {
            public string uri;
            public string id;
            public string extensionNumber;
        }
    }

    public partial class Extension : Model
    {
        internal Extension(Model parent, string _id = null) : base(parent, _id) { }
        public Extension() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "extension";
            }
        }

        public System.Threading.Tasks.Task<Extension> Get(object queryParams = null)
        {
            return Get<Extension>(queryParams);
        }
    }

}