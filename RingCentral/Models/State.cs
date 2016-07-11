using System.Threading.Tasks;

namespace RingCentral
{
    public partial class State : Model
    {
        public Task<States> List(object queryParams = null)
        {
            return List<States>(queryParams);
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