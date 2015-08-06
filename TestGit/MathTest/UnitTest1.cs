using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestGit;
using NUnit.Framework;

namespace MathTest
{
    [TestClass]
    public class UnitTest1
    {        
        [TestCase(1,2)]
        public void TestMethod1(int a,int b)
        {
            TestGit.Math _m = new TestGit.Math();

            NUnit.Framework.Assert.AreEqual(_m.add(a, b), 3);
        }

       
    }
}
