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
        CourseInfo windowsProgrammingCourseInfo = new CourseInfo("291710", "視窗程式設計", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "3 4 6", "", "", "二教206(e)\r\n二教205(e)", "43", "19", "", "", "查詢", "◎兼任陳偉凱老師,限52人", "", "");
        CourseInfo windowsProgrammingCourseInfo2 = new CourseInfo("123456", "視窗程式設計", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "3 4 6", "", "", "二教206(e)\r\n二教205(e)", "43", "19", "", "", "查詢", "◎兼任陳偉凱老師,限52人", "", "");
        CourseInfo windowsProgrammingCourseInfo3 = new CourseInfo("7890", "視窗程式設計", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "3 4 6", "", "", "二教206(e)\r\n二教205(e)", "43", "19", "", "", "查詢", "◎兼任陳偉凱老師,限52人", "", "");

        //Initialize
        [TestInitialize()]
        public void SetUp()
        {
            model = new Model();
        }

        //ModelTest
        [TestMethod()]
        public void ModelTest()
        {
            Assert.AreEqual(2, model.GetCourseListCollection.Count());
        }

        //UpdateCourseListInfoTest
        [TestMethod()]
        public void UpdateCourseListInfoTest()
        {
            model.UpdateCourseListInfo((int)Department.ComputerScience3 / 2);
            int count = model.GetCourseList((int)Department.ComputerScience3 / 2).Count();
            Assert.AreNotEqual(0, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
            model.UpdateCourseListInfo((int)Department.ComputerScience3 / 2);
            Assert.AreEqual(count, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
        }

        //UpdateCourseListInfoWithDuplicateAtSameClassTest
        [TestMethod()]
        public void UpdateCourseListInfoWithDuplicateAtSameClassTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            model.UpdateCourseListInfo((int)Department.ComputerScience3 / 2);
            int count = model.GetCourseList((int)Department.ComputerScience3 / 2).Count();
            Assert.AreNotEqual(0, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
            model.UpdateCourseListInfo((int)Department.ComputerScience3 / 2);
            Assert.AreEqual(count, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
        }

        //UpdateCourseListInfoWithDuplicateAtAnotherClassTest
        [TestMethod()]
        public void UpdateCourseListInfoWithDuplicateAtAnotherClassTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ElectronicEngineering3 / 2);
            model.UpdateCourseListInfo((int)Department.ComputerScience3 / 2);
            int count = model.GetCourseList((int)Department.ComputerScience3 / 2).Count();
            Assert.AreNotEqual(0, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
            model.UpdateCourseListInfo((int)Department.ComputerScience3 / 2);
            Assert.AreEqual(count, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
        }

        //GetCourseListTest
        [TestMethod()]
        public void GetCourseListTest()
        {
            Assert.AreEqual(0, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
        }

        //RemoveFromCourseListAndAddInToSelectedTabTest
        [TestMethod()]
        public void RemoveFromCourseListAndAddInToSelectedTabTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            model.AddSelectedCourse(windowsProgrammingCourseInfo);
            model.RemoveFromCourseListAndAddInToSelectedTab((int)Department.ComputerScience3 / 2, 0);
            Assert.AreEqual(0, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
            Assert.AreEqual(Tuple.Create(-2, (int)Department.ComputerScience3 / 2, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //RemoveCourseFromCourseListTest
        [TestMethod()]
        public void RemoveCourseFromCourseListTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            model.RemoveCourseFromCourseList((int)Department.ComputerScience3 / 2, 0);
            Assert.AreEqual(0, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
        }

        //RemoveCourseFromSelectionResultTest
        [TestMethod()]
        public void RemoveCourseFromSelectionResultTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            model.RemoveCourseFromSelectionResult(0);
            Assert.AreEqual(0, model.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetCourseList((int)Department.ComputerScience3 / 2)[0]);
            Assert.AreEqual(1, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
            Assert.AreEqual(Tuple.Create((int)Department.ComputerScience3 / 2, (int)Department.ComputerScience3 / 2, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //RemoveCourseFromSelectedListTest
        [TestMethod()]
        public void RemoveCourseFromSelectedListTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            model.RemoveCourseFromSelectedList(0);
            Assert.AreEqual(0, model.GetSelectedCourseList.Count());
        }

        //GetCourseInfoBySelectedIndexForCourseTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexForCourseTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetCourseInfoBySelectedIndex(0));
        }

        //GetCourseInfoBySelectedIndexForSelectedCourseTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexForSelectedCourseTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
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
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(Tuple.Create((int)Department.ComputerScience3 / 2, (int)Department.ComputerScience3 / 2, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //GetCourseDepartmentBySelectedIndexForSelectedCourseTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexForSelectedCourseTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(Tuple.Create(-2, (int)Department.ComputerScience3 / 2, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //GetCourseDepartmentBySelectedIndexForNotEnabledCourseTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexForNotEnabledCourseTest()
        {
            model.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(Tuple.Create(-1, (int)Department.ComputerScience3, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //AddIntoSelectedCourseListAndCourseTabTest
        [TestMethod()]
        public void AddIntoSelectedCourseListAndCourseTabTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(1, model.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetSelectedCourseList[0]);
            Assert.AreEqual(Tuple.Create(-2, (int)Department.ComputerScience3 / 2, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //AddIntoNotEnabledCourseListAndCourseTabTest
        [TestMethod()]
        public void AddIntoNotEnabledCourseListAndCourseTabTest()
        {
            model.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(1, model.GetNotEnabledCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetNotEnabledCourseList[0]);
            Assert.AreEqual(Tuple.Create(-1, (int)Department.ComputerScience3, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //AddIntoCourseListTest
        [TestMethod()]
        public void AddIntoCourseListTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(1, model.GetCourseList((int)Department.ComputerScience3 / 2).Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetCourseList((int)Department.ComputerScience3 / 2)[0]);
            Assert.AreEqual(Tuple.Create((int)Department.ComputerScience3 / 2, (int)Department.ComputerScience3 / 2, 0), model.GetCourseDepartmentBySelectedIndex(0));
        }

        //RemoveCourseFromSelectedTabDictionaryTest
        [TestMethod()]
        public void RemoveCourseFromSelectedTabDictionaryTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            model.RemoveCourseFromSelectedTabDictionary(0);
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ElectronicEngineering3 / 2);
            Assert.AreEqual(Tuple.Create(-2, (int)Department.ElectronicEngineering3 / 2, 1), model.GetCourseDepartmentBySelectedIndex(1));
        }

        //RemoveCourseFromNotEnabledTabDictionaryTest
        [TestMethod()]
        public void RemoveCourseFromNotEnabledTabDictionaryTest()
        {
            model.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            model.RemoveCourseFromNotEnabledTabDictionary(0);
            model.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ElectronicEngineering3);
            Assert.AreEqual(Tuple.Create(-1, (int)Department.ElectronicEngineering3, 1), model.GetCourseDepartmentBySelectedIndex(1));
        }

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
            model.ReloadAllForm();
            Assert.IsFalse(isNotifyObserverWork);
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

        //GetClassListForSelectedIndexTest
        [TestMethod()]
        public void GetClassListForSelectedIndexTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo2, (int)Department.ComputerScience3 / 2);
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo3, (int)Department.ElectronicEngineering3 / 2);
            model.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo3, (int)Department.ComputerScience3);
            model.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo2, (int)Department.ElectronicEngineering3);
            Assert.AreEqual(3, model.GetClassListForSelectedIndex((int)Department.ComputerScience3 / 2).Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetClassListForSelectedIndex((int)Department.ComputerScience3 / 2)[0]);
            Assert.AreEqual(windowsProgrammingCourseInfo2, model.GetClassListForSelectedIndex((int)Department.ComputerScience3 / 2)[1]);
            Assert.AreEqual(windowsProgrammingCourseInfo3, model.GetClassListForSelectedIndex((int)Department.ComputerScience3 / 2)[2]);
        }

        //AddClassNameListTestForKnownName
        [TestMethod()]
        public void AddClassNameListTestForKnownName()
        {
            model.AddClassNameList("資工所");
            model.UpdateCourseListInfo(2);
            model.AddClassNameList("資工一");
            model.UpdateCourseListInfo(3);
            model.AddClassNameList("資工二");
            model.UpdateCourseListInfo(4);
            model.AddClassNameList("資工四");
            model.UpdateCourseListInfo(5);
            Assert.AreEqual(6, model.GetCourseListCollection.Count());
            Assert.AreNotEqual(0, model.GetCourseList(2).Count());
            Assert.AreNotEqual(0, model.GetCourseList(3).Count());
            Assert.AreNotEqual(0, model.GetCourseList(4).Count());
            Assert.AreNotEqual(0, model.GetCourseList(5).Count());
        }

        //AddClassNameListTestForNotKnownName
        [TestMethod()]
        public void AddClassNameListTestForNotKnownName()
        {
            model.AddClassNameList("電資三");
            model.UpdateCourseListInfo(2);
            Assert.AreEqual(3, model.GetCourseListCollection.Count());
            Assert.AreEqual(0, model.GetCourseList(2).Count());
        }
    }
}