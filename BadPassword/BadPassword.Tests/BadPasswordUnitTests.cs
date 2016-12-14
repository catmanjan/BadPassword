using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BadPassword.Tests
{
    [TestClass]
    public class BadPasswordUnitTests
    {
        [TestMethod]
        public void CheckBadPasswords()
        {
            Assert.IsTrue("password".IsBadPassword());
            Assert.IsTrue("123456".IsBadPassword());
            Assert.IsTrue("helloworld".IsBadPassword());
        }

        [TestMethod]
        public void CheckGoodPasswords()
        {
            Assert.IsFalse("iRHaluzn32vhMUEWP5Vz".IsBadPassword());
            Assert.IsFalse("1j3GR0FuG0n5AcDxyXGe".IsBadPassword());
            Assert.IsFalse("z52EANOp66oZS0e2d0cf".IsBadPassword());
        }
    }
}
