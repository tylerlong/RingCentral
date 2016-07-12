namespace RingCentral
{
    public partial class AuthzProfile
    {
        public string uri;
        public Permission[] permissions;

        public class Permission
        {
            public _Permission permission;
            public EffectiveRole effectiveRole;
            public string[] scopes;

            public class _Permission
            {
                public string uri;
                public string id;
            }

            public class EffectiveRole
            {
                public string uri;
                public string id;
            }
        }
    }

    public partial class AuthzProfile : Model
    {
        internal AuthzProfile(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "authz-profile";
            }
        }
    }

    public partial class AuthzProfile : Model
    {
        public AuthzProfile() : base(null) { }

        public System.Threading.Tasks.Task<AuthzProfile> Get(object queryParams = null)
        {
            return Get<AuthzProfile>(queryParams);
        }
    }
}