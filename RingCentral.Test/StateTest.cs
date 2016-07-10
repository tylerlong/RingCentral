using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class StateTest : BaseTest
    {
        [Test]
        public void TestCase()
        {
            var state = rc.Get<State>("/restapi/v1.0/dictionary/state/16").Result;
            Assert.NotNull(state);
            Assert.AreEqual("California", state.name);

            var state2 = rc.RestApi().Dictionary().State("16").Get().Result;
            DeepEqual(state, state2);
        }

        [Test]
        public void TestCase2()
        {
            var states = rc.Get<States>("/restapi/v1.0/dictionary/state").Result;
            Assert.NotNull(states);
            Assert.Greater(states.records.Length, 1);

            var states2 = rc.RestApi().Dictionary().State().List().Result;
            DeepEqual(states, states2);
        }
    }
}