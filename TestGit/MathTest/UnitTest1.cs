using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestGit;


namespace MathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestGit.Math _m = new TestGit.Math();
            int result=_m.add(4,3);
            NUnit.Framework.Assert.AreEqual(result, 7);
        }
    }
}
