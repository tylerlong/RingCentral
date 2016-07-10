using System.Threading.Tasks;

namespace RingCentral
{
    public partial class State : Model
    {
        public Task<State> Get(object queryParameters = null)
        {
            return Get<State>(queryParameters);
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