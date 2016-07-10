using System;
using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class OAuthTest : BaseTest
    {
        [Test]
        public void TestCase()
        {
            var redirectUri = "http://localhost:3000";
            var state = "myState";
            var authorizeUri = rc.AuthorizeUri(redirectUri, state);
            var expectedUri = rc.server + "/restapi/oauth/authorize";
            expectedUri += "?response_type=code";
            expectedUri += "&state=" + state;
            expectedUri += "&redirect_uri=" + Uri.EscapeDataString(redirectUri);
            expectedUri += "&client_id=" + rc.appKey;
            Assert.AreEqual(expectedUri, authorizeUri);
        }

        [Test]
        public void TestUriEscape()
        {
            var uri = "http://localhost:3000";
            var escapedUri = "http%3A%2F%2Flocalhost%3A3000";
            Assert.AreEqual(uri, Uri.EscapeUriString(uri)); // EscapeUriString has no effect for uri
            Assert.AreEqual(escapedUri, Uri.EscapeDataString(uri));
        }
    }
}