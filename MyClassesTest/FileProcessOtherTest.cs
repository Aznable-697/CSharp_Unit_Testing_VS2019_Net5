using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;
using System.IO;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessOtherTest : TestBase
    {
        [ClassInitialize()]
        public static void ClassInitialize(TestContext tc)
        {
            // TODO: Initialize for all tests in Class add any and all Data here
            tc.WriteLine("In ClassInitialize() method");
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            //TODO: Clean up after all tests in Class

        }
        
        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("In TestInitialize() method");

            WriteDescription(this.GetType());

            if (TestContext.TestName.StartsWith("FileNameDoesExist"))
            {
                SetGoodFileName();
                if (!string.IsNullOrEmpty(_GoodFileName))
                {
                    TestContext.WriteLine("Creating file: " + _GoodFileName);
                    // Create the 'Good' File
                    File.AppendAllText(_GoodFileName, "Some Text");
                }
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("In TestCleanup() method");

            if (TestContext.TestName.StartsWith("FileNameDoesExist"))
            {
                // Delete the File
                if (File.Exists(_GoodFileName))
                {
                    TestContext.WriteLine("Deleting file: " + _GoodFileName);
                    File.Delete(_GoodFileName);
                }
            }
        }

        [TestMethod]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }

        [TestMethod]
        public void AreEqualTest()
        {
            string str1 = "Matt";
            string str2 = "matt";

            Assert.AreEqual(str1, str2, true);
        }

        [TestMethod]
        public void AreNotEqualTest()
        {
            string str1 = "Matt";
            string str2 = "Mike";

            Assert.AreNotEqual(str1, str2);
        }

        [TestMethod]
        public void FileNameDoesExistSimpleMessage()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(_GoodFileName);

            Assert.IsFalse(fromCall, "File {0}Does Not Exist.", _GoodFileName);
        }
        
    }
}
