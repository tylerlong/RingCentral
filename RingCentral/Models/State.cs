using System.Threading.Tasks;

namespace RingCentral
{
    public partial class State
    {
    }

    public static class StateExtensions
    {
        public static State State(this Dictionary dictionary, string _id = null)
        {
            return new State(dictionary, _id);
        }
    }
}