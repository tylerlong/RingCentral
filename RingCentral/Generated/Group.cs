namespace RingCentral
{
    public partial class Group
    {
        public string uri;
        public Contacts contacts;
        public double? id;
        public string notes;
        public string groupName;
        public int? contactsCount;

        public class Contacts
        {
            public string uri;
        }
    }

    public partial class Group : Model
    {
        internal Group(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "group";
            }
        }
    }

    public partial class Group : Model
    {
        public Group() : base(null) { }

        public System.Threading.Tasks.Task<Group> Get(object queryParams = null)
        {
            return Get<Group>(queryParams);
        }
    }
}