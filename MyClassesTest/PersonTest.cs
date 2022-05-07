using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class PersonTest : TestBase
    {
        [TestMethod]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;
            per = mgr.CreatePerson("", "Whiteker", true);

            Assert.IsNull(per);
        }

        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("Matthew", "Whiteker",
                                           true);

            Assert.IsInstanceOfType(per,
                        typeof(Supervisor));
        }
    }
}
