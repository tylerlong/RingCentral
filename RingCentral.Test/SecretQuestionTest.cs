using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class SecretQuestionTest : BaseTest
    {
        [Test]
        public void TestCase()
        {
            var sq = rc.Get<SecretQuestion>("/restapi/v1.0/dictionary/secret-question/3").Result;
            Assert.NotNull(sq);
            Assert.AreEqual(1033, sq.languageId);

            var sq2 = rc.RestApi().Dictionary().SecretQuestion("3").Get().Result;
            DeepEqual(sq, sq2);
        }

        [Test]
        public void TestCase2()
        {
            var sqs = rc.Get<SecretQuestions>("/restapi/v1.0/dictionary/secret-question").Result;
            Assert.NotNull(sqs);
            Assert.GreaterOrEqual(sqs.records.Length, 1);

            var sqs2 = rc.RestApi().Dictionary().SecretQuestion().List().Result;
            DeepEqual(sqs, sqs2);
        }
    }
}