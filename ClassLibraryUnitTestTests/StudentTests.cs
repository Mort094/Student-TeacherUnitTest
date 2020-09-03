using ClassLibraryUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ClassLibraryUnitTest.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private Student stu;

        [TestInitialize]
        public void Init()
        {
            stu = new Student();
        }


        [TestMethod]
        public void StudentTestName()
        {
            stu.Name = "bo";
            Assert.AreEqual("bo", stu.Name);
            Assert.ThrowsException<ArgumentOutOfRangeException> (()=> stu.Name = "b");
        }

        [TestMethod]
        public void StudentTestAddress()
        {
            stu.Address = "roskilde";
            Assert.ThrowsException<ArgumentNullException>(() => stu.Address = null);
            Assert.AreEqual("roskilde", stu.Address);
        }

        [TestMethod]
        public void StudentTestSemester()
        {
            stu.Semester = 1;
            Assert.AreEqual(1, stu.Semester);
            stu.Semester = 8;
            Assert.AreEqual(8, stu.Semester);
            //stu.Semester = 0;
            //Assert.AreEqual(0,stu.Semester);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => stu.Semester = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => stu.Semester = 9);

        }

        [TestMethod]
        public void StudentTestGender()
        {
            stu.Gender = GenderType.male;
            Assert.AreEqual(GenderType.male, stu.Gender);
        }

        //[TestMethod]
        //public void ToStringTest()
        //{
        //    Assert.Fail();
        //}
    }
}