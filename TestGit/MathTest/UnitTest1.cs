using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestGit;
using NUnit.Framework;

namespace MathTest
{
    [TestClass]
    public class UnitTest1
    {        
        [TestCase(5,2)]
        public void TestMethod1(int a,int b)
        {
            TestGit.Math _m = new TestGit.Math();

            NUnit.Framework.Assert.AreEqual(_m.add(a, b), 7);
        }

        [TestCase(8, 7)]
        public void TestMethod2(int a, int b)
        {
            TestGit.Math _m = new TestGit.Math();

            NUnit.Framework.Assert.AreNotEqual(_m.add(a, b), 7);
        }
       
    }
}
