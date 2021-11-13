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
    public class ModelTests
    {
        Model model;
        CourseInfo windowsProgrammingCourseInfo = new CourseInfo("291710", "視窗程式設計", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "3 4 6", "", "", "二教206(e)\n二教205(e)", "43", "15", "", "", "", "查詢", "", "");

        //Initialize
        [TestInitialize()]
        public void SetUp()
        {
            model = new Model();
        }

        ////ModelTest
        //[TestMethod()]
        //public void ModelTest()
        //{
        //    Assert.Fail();
        //}

        //UpdateCourseListInfoTest
        [TestMethod()]
        public void UpdateCourseListInfoTest()
        {
            model.UpdateCourseListInfo((int)Department.ComputerScience3);
            int count = model.GetCourseList((int)Department.ComputerScience3).Count();
            Assert.AreNotEqual(0, model.GetCourseList((int)Department.ComputerScience3).Count());
            model.UpdateCourseListInfo((int)Department.ComputerScience3);
            Assert.AreEqual(count, model.GetCourseList((int)Department.ComputerScience3).Count());
        }

        //GetCourseListTest
        [TestMethod()]
        public void GetCourseListTest()
        {
            Assert.AreEqual(0, model.GetCourseList((int)Department.ComputerScience3).Count());
        }

        //RemoveFromCourseListAndAddInToSelectedTabTest
        [TestMethod()]
        public void RemoveFromCourseListAndAddInToSelectedTabTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            model.RemoveFromCourseListAndAddInToSelectedTab((int)Department.ComputerScience3, 0);
            Assert.AreEqual(0, model.GetCourseList((int)Department.ComputerScience3).Count());
        }

        //RemoveCourseFromCourseListTest
        [TestMethod()]
        public void RemoveCourseFromCourseListTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            model.RemoveCourseFromCourseList((int)Department.ComputerScience3, 0);
            Assert.AreEqual(0, model.GetCourseList((int)Department.ComputerScience3).Count());
        }

        //RemoveCourseFromSelectionResultTest
        [TestMethod()]
        public void RemoveCourseFromSelectionResultTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            model.RemoveCourseFromSelectionResult(0);
            Assert.AreEqual(0, model.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetCourseList((int)Department.ComputerScience3)[0]);
            Assert.AreEqual(1, model.GetCourseList((int)Department.ComputerScience3).Count());
        }

        //RemoveCourseFromSelectedListTest
        [TestMethod()]
        public void RemoveCourseFromSelectedListTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            model.RemoveCourseFromSelectedList(0);
            Assert.AreEqual(0, model.GetSelectedCourseList.Count());
        }

        //GetCourseInfoBySelectedIndexForCourseTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexForCourseTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetCourseInfoBySelectedIndex(0));
        }

        //GetCourseInfoBySelectedIndexForSelectedCourseTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexForSelectedCourseTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetCourseInfoBySelectedIndex(0));
        }

        //GetCourseInfoBySelectedIndexForNotEnabledCourseTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexForNotEnabledCourseTest()
        {
            model.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetCourseInfoBySelectedIndex(0));
        }

        //GetCourseDepartmentBySelectedIndexForCourseTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexForCourseTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(Tuple.Create((int)ListName.ComputerScience3, (int)Department.ComputerScience3, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //GetCourseDepartmentBySelectedIndexForSelectedCourseTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexForSelectedCourseTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(Tuple.Create((int)ListName.SelectedList, (int)Department.ComputerScience3, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //GetCourseDepartmentBySelectedIndexForNotEnabledCourseTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexForNotEnabledCourseTest()
        {
            model.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(Tuple.Create((int)ListName.NotEnabledList, (int)Department.ComputerScience3, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //AddIntoSelectedCourseListAndCourseTabTest
        [TestMethod()]
        public void AddIntoSelectedCourseListAndCourseTabTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(1, model.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetSelectedCourseList[0]);
        }

        //AddIntoNotEnabledCourseListAndCourseTabTest
        [TestMethod()]
        public void AddIntoNotEnabledCourseListAndCourseTabTest()
        {
            model.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(1, model.GetNotEnabledCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetNotEnabledCourseList[0]);
        }

        //AddIntoCourseListTest
        [TestMethod()]
        public void AddIntoCourseListTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(1, model.GetCourseList((int)Department.ComputerScience3).Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetCourseList((int)Department.ComputerScience3)[0]);
        }

        ////RemoveCourseFromSelectedTabDictionaryTest
        //[TestMethod()]
        //public void RemoveCourseFromSelectedTabDictionaryTest()
        //{
        //    Assert.Fail();
        //}

        ////RemoveCourseFromNotEnabledTabDictionaryTest
        //[TestMethod()]
        //public void RemoveCourseFromNotEnabledTabDictionaryTest()
        //{
        //    Assert.Fail();
        //}

        //AddSelectedCourseTest
        [TestMethod()]
        public void AddSelectedCourseTest()
        {
            model.AddSelectedCourse(windowsProgrammingCourseInfo);
            Assert.AreEqual(1, model.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetSelectedCourseList[0]);
        }

        //ReloadAllFormTest
        [TestMethod()]
        public void ReloadAllFormTest()
        {
            bool isNotifyObserverWork = false;
            model._modelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            model.ReloadAllForm();
            Assert.IsTrue(isNotifyObserverWork);
        }

        //NotifyObserverTest
        [TestMethod()]
        public void NotifyObserverTest()
        {
            bool isNotifyObserverWork = false;
            model._modelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            model.NotifyObserver();
            Assert.IsTrue(isNotifyObserverWork);
        }
    }
}