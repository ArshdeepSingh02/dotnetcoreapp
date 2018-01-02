using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnetcoreapptest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public bool IsOneOne()
        {
            if (1 == 1)
                return true;
        }
    }
}
