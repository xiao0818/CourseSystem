using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem.Tests
{
    [TestClass()]
    public class CourseInfoTests
    {
        CourseInfo windowsProgrammingCourseInfo;

        //Initialize
        [TestInitialize]
        public void SetUp()
        {
            windowsProgrammingCourseInfo = new CourseInfo("291710", "視窗程式設計", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "3 4 6", "", "", "二教206(e)\r\n二教205(e)", "43", "19", "", "", "查詢", "◎兼任陳偉凱老師,限52人", "", "");
        }

        //CourseInfoTest
        [TestMethod()]
        public void CourseInfoTest()
        {
            Assert.AreEqual("291710", windowsProgrammingCourseInfo.GetCourseInfoString[0]);
        }

        //GetCourseClassTimeTest
        [TestMethod()]
        public void GetCourseClassTimeTest()
        {
            List<Tuple<int, string>> courseClassTime = new List<Tuple<int, string>>();
            courseClassTime.Add(Tuple.Create(4, "3"));
            courseClassTime.Add(Tuple.Create(4, "4"));
            courseClassTime.Add(Tuple.Create(4, "6"));
            CollectionAssert.AreEqual(courseClassTime, windowsProgrammingCourseInfo.GetCourseClassTime());
        }
    }
}