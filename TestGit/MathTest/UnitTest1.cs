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
           NUnit.Framework.Assert.AreEqual(a + b, 3);
        }
    }
}
