using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class LanguageTest : BaseTest
    {
        [Test]
        public void TestCase()
        {
            var language = rc.Get<Language>("/restapi/v1.0/dictionary/language/1033").Result;
            Assert.NotNull(language);
            Assert.AreEqual("English (United States)", language.name);

            var language2 = rc.RestApi().Dictionary().Language("1033").Get().Result;
            DeepEqual(language, language2);
        }

        [Test]
        public void TestCase2()
        {
            var languages = rc.Get<Languages>("/restapi/v1.0/dictionary/language").Result;
            Assert.NotNull(languages);
            Assert.GreaterOrEqual(languages.records.Length, 1);

            var languages2 = rc.RestApi().Dictionary().Language().List().Result;
            DeepEqual(languages, languages2);
        }
    }
}