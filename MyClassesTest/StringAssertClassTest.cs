using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class StringAssertClassTest : TestBase
    {
        [TestMethod]
        public void ContainsTest()
        {
            string str1 = "Steve NyStorm";
            string str2 = "Nystrom";

            StringAssert.Contains(str1, str2);
        }

        [TestMethod]
        public void StartsWithTest()
        {
            string str1 = "All Lower Case";
            string str2 = "All Lower";

            StringAssert.StartsWith(str1, str2);
                
        }
    }
}
