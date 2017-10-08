using System;
using NUnit.Framework;
namespace NoobCore.NUnitTests
{
    public class NUnitTest
    {
        [TestCase]
        public void PassTest()
        {
            Assert.Pass();
        }
    }
}
