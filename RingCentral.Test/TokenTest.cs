﻿using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class TokenTest : BaseTest
    {
        [Test]
        public void TestToken()
        {
            Assert.IsNotNull(rc);
            Assert.IsNotNull(rc.token);
            Assert.IsNotNull(rc.token.access_token);
        }
    }
}