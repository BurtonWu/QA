using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestNUnit
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void firstTest()
        {
            int x = 1;
            int y = 2;
            Assert.AreEqual(x, y);
        }
        [Test]
        public void secondTest()
        {
            if(true)
                Assert.Fail("this is a failure");
        }

        [Test, ExpectedException(typeof(NotSupportedException))]
        public void expectTest()
        {
            //this would normally fail but we expected it with the attirbute
            throw new NotSupportedException();
        }

        [Test,Ignore]
        public void doNotRunTest()
        {
            throw new NotImplementedException();
        }
    }
}
