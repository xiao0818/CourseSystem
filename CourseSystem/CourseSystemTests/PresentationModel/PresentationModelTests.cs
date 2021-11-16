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
    public class PresentationModelTests
    {
        Model model;
        PresentationModel presentationModel;
        CourseInfo windowsProgrammingCourseInfo = new CourseInfo("291710", "視窗程式設計", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "3 4 6", "", "", "二教206(e)\n二教205(e)", "43", "15", "", "", "", "查詢", "", "");

        //Initialize
        [TestInitialize]
        public void SetUp()
        {
            model = new Model();
            presentationModel = new PresentationModel(model);
        }

        //PresentationModelTest
        [TestMethod()]
        public void PresentationModelTest()
        {
            Assert.IsFalse(presentationModel.IsLoadComputerScienceCourseTab);
        }

        //UpdateCourseListInfoTest
        [TestMethod()]
        public void UpdateCourseListInfoTest()
        {
            presentationModel.UpdateCourseListInfo((int)Department.ComputerScience3);
            Assert.AreNotEqual(0, presentationModel.GetCourseList((int)Department.ComputerScience3).Count());
        }

        //GetCourseListTest
        [TestMethod()]
        public void GetCourseListTest()
        {
            Assert.AreEqual(0, presentationModel.GetCourseList((int)Department.ComputerScience3).Count());
        }

        //RemoveFromCourseListAndAddInToSelectedTabTest
        [TestMethod()]
        public void RemoveFromCourseListAndAddInToSelectedTabTest()
        {
            presentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            presentationModel.AddSelectedCourse(windowsProgrammingCourseInfo);
            presentationModel.RemoveFromCourseListAndAddInToSelectedTab((int)Department.ComputerScience3, 0);
            Assert.AreEqual(0, presentationModel.GetCourseList((int)Department.ComputerScience3).Count());
            Assert.AreEqual(Tuple.Create((int)Department.SelectedList, (int)Department.ComputerScience3, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //RemoveCourseFromCourseListTest
        [TestMethod()]
        public void RemoveCourseFromCourseListTest()
        {
            presentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            presentationModel.RemoveCourseFromCourseList((int)Department.ComputerScience3, 0);
            Assert.AreEqual(0, presentationModel.GetCourseList((int)Department.ComputerScience3).Count());
        }

        //RemoveCourseFromSelectionResultTest
        [TestMethod()]
        public void RemoveCourseFromSelectionResultTest()
        {
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            presentationModel.RemoveCourseFromSelectionResult(0);
            Assert.AreEqual(0, presentationModel.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, presentationModel.GetCourseList((int)Department.ComputerScience3)[0]);
            Assert.AreEqual(1, presentationModel.GetCourseList((int)Department.ComputerScience3).Count());
            Assert.AreEqual(Tuple.Create((int)Department.ComputerScience3, (int)Department.ComputerScience3, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //RemoveCourseFromSelectedListTest
        [TestMethod()]
        public void RemoveCourseFromSelectedListTest()
        {
            presentationModel.AddSelectedCourse(windowsProgrammingCourseInfo);
            presentationModel.RemoveCourseFromSelectedList(0);
            Assert.AreEqual(0, presentationModel.GetSelectedCourseList.Count());
        }

        //CheckCourseListSuccessTest
        [TestMethod()]
        public void CheckCourseListSuccessTest()
        {
            List<CourseInfo> emptyList = new List<CourseInfo>();
            List<CourseInfo> courseList = new List<CourseInfo>();
            courseList.Add(windowsProgrammingCourseInfo);
            Assert.AreEqual("", presentationModel.CheckCourseList(courseList, emptyList));
        }

        //CheckCourseListFailTest
        [TestMethod()]
        public void CheckCourseListFailTest()
        {
            List<CourseInfo> courseList = new List<CourseInfo>();
            courseList.Add(windowsProgrammingCourseInfo);
            Assert.AreEqual("\n課號相同:「291710 視窗程式設計」\n課程名稱相同:「291710 視窗程式設計」\n衝堂:「291710 視窗程式設計」", presentationModel.CheckCourseList(courseList, courseList));
        }

        //GetCourseInfoBySelectedIndexForCourseTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexForCourseTest()
        {
            presentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(windowsProgrammingCourseInfo, presentationModel.GetCourseInfoBySelectedIndex(0));
        }

        //GetCourseInfoBySelectedIndexForSelectedCourseTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexForSelectedCourseTest()
        {
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(windowsProgrammingCourseInfo, presentationModel.GetCourseInfoBySelectedIndex(0));
        }

        //GetCourseInfoBySelectedIndexForNotEnabledCourseTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexForNotEnabledCourseTest()
        {
            presentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(windowsProgrammingCourseInfo, presentationModel.GetCourseInfoBySelectedIndex(0));
        }

        //GetCourseDepartmentBySelectedIndexForCourseTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexForCourseTest()
        {
            presentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(Tuple.Create((int)Department.ComputerScience3, (int)Department.ComputerScience3, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //GetCourseDepartmentBySelectedIndexForSelectedCourseTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexForSelectedCourseTest()
        {
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(Tuple.Create((int)Department.SelectedList, (int)Department.ComputerScience3, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //GetCourseDepartmentBySelectedIndexForNotEnabledCourseTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexForNotEnabledCourseTest()
        {
            presentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(Tuple.Create((int)Department.NotEnabledList, (int)Department.ComputerScience3, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //AddIntoSelectedCourseListAndCourseTabTest
        [TestMethod()]
        public void AddIntoSelectedCourseListAndCourseTabTest()
        {
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(1, presentationModel.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, presentationModel.GetSelectedCourseList[0]);
            Assert.AreEqual(Tuple.Create((int)Department.SelectedList, (int)Department.ComputerScience3, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //AddIntoNotEnabledCourseListAndCourseTabTest
        [TestMethod()]
        public void AddIntoNotEnabledCourseListAndCourseTabTest()
        {
            presentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(1, presentationModel.GetNotEnabledCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, presentationModel.GetNotEnabledCourseList[0]);
            Assert.AreEqual(Tuple.Create((int)Department.NotEnabledList, (int)Department.ComputerScience3, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //AddIntoCourseListTest
        [TestMethod()]
        public void AddIntoCourseListTest()
        {
            presentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(1, presentationModel.GetCourseList((int)Department.ComputerScience3).Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, presentationModel.GetCourseList((int)Department.ComputerScience3)[0]);
            Assert.AreEqual(Tuple.Create((int)Department.ComputerScience3, (int)Department.ComputerScience3, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //RemoveCourseFromSelectedTabDictionaryTest
        [TestMethod()]
        public void RemoveCourseFromSelectedTabDictionaryTest()
        {
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            presentationModel.RemoveCourseFromSelectedTabDictionary(0);
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ElectronicEngineering3);
            Assert.AreEqual(Tuple.Create((int)Department.SelectedList, (int)Department.ElectronicEngineering3, 1), presentationModel.GetCourseDepartmentBySelectedIndex(1));
        }

        //RemoveCourseFromNotEnabledTabDictionaryTest
        [TestMethod()]
        public void RemoveCourseFromNotEnabledTabDictionaryTest()
        {
            presentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            presentationModel.RemoveCourseFromNotEnabledTabDictionary(0);
            presentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ElectronicEngineering3);
            Assert.AreEqual(Tuple.Create((int)Department.NotEnabledList, (int)Department.ElectronicEngineering3, 1), presentationModel.GetCourseDepartmentBySelectedIndex(1));
        }

        //AddSelectedCourseTest
        [TestMethod()]
        public void AddSelectedCourseTest()
        {
            presentationModel.AddSelectedCourse(windowsProgrammingCourseInfo);
            Assert.AreEqual(1, presentationModel.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, presentationModel.GetSelectedCourseList[0]);
        }

        //ClickLoadComputerScienceCourseTabButtonTest
        [TestMethod()]
        public void ClickLoadComputerScienceCourseTabButtonTest()
        {
            presentationModel.ClickLoadComputerScienceCourseTabButton();
            Assert.IsTrue(presentationModel.IsLoadComputerScienceCourseTab);
        }

        //FinishLoadComputerScienceCourseTabButtonTest
        [TestMethod()]
        public void FinishLoadComputerScienceCourseTabButtonTest()
        {
            presentationModel.ClickLoadComputerScienceCourseTabButton();
            presentationModel.FinishLoadComputerScienceCourseTabButton();
            Assert.IsFalse(presentationModel.IsLoadComputerScienceCourseTab);
        }

        //WaitSecondsTest
        [TestMethod()]
        public void WaitSecondsTest()
        {
            DateTime now = DateTime.Now;
            presentationModel.WaitSeconds(1);
            Assert.AreEqual(DateTime.Now.Second, now.AddSeconds(1).Second);
        }

        //WaitSecondsTestFail
        [TestMethod()]
        public void WaitSecondsTestFail()
        {
            DateTime now = DateTime.Now;
            presentationModel.WaitSeconds(0);
            Assert.AreEqual(DateTime.Now.Second, now.Second);
        }

        //ReloadAllFormTest
        [TestMethod()]
        public void ReloadAllFormTest()
        {
            bool isNotifyObserverWork = false;
            presentationModel._presentationModelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            presentationModel.ReloadAllForm();
            Assert.IsTrue(isNotifyObserverWork);
        }

        //NotifyObserverTest
        [TestMethod()]
        public void NotifyObserverTest()
        {
            bool isNotifyObserverWork = false;
            presentationModel._presentationModelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            presentationModel.NotifyObserver();
            Assert.IsTrue(isNotifyObserverWork);
        }
    }
}