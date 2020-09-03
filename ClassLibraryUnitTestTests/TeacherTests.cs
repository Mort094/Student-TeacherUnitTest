using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryUnitTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryUnitTest.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        private Teacher teacher;
        [TestInitialize]
        public void Init()
        {
            teacher = new Teacher();
        }
        [TestMethod()]
        public void TeacherTest()
        {
            Assert.Fail();
        }
    }
}