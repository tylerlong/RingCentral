using System.Threading.Tasks;

namespace RingCentral
{
    public partial class State : Model
    {
        internal State(Model parent, string _id = null) : base(parent, _id) { }

        public Task<State> Get(object queryParameters = null)
        {
            return RestClient.Get<State>(Endpoint, queryParameters);
        }

        public Task<States> List(object queryParameters = null)
        {
            return List<States>(queryParameters);
        }
    }

    public static class StateExtensions
    {
        public static State State(this Dictionary dictionary, string _id = null)
        {
            return new State(dictionary, _id);
        }
    }
}
