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
    public class CourseSelectingFormPresentationModelTests
    {
        CourseSelectingFormPresentationModel courseSelectingFormPresentationModel;
        PresentationModel presentationModel;
        Model model;
        CourseInfo windowsProgrammingCourseInfo = new CourseInfo("291710", "視窗程式設計", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "3 4 6", "", "", "二教206(e)\r\n二教205(e)", "43", "19", "", "", "查詢", "◎兼任陳偉凱老師,限52人", "", "");

        //Initialize
        [TestInitialize]
        public void SetUp()
        {
            model = new Model();
            presentationModel = new PresentationModel(model);
            courseSelectingFormPresentationModel = new CourseSelectingFormPresentationModel(presentationModel);
        }

        //CourseSelectingFormPresentationModelTest
        [TestMethod()]
        public void CourseSelectingFormPresentationModelTest()
        {
            Assert.IsTrue(courseSelectingFormPresentationModel.IsCheckButtonEnabled);
            Assert.IsFalse(courseSelectingFormPresentationModel.IsSubmitButtonEnabled);
        }

        //UpdateCourseListInfoTest
        [TestMethod()]
        public void UpdateCourseListInfoTest()
        {
            courseSelectingFormPresentationModel.UpdateCourseListInfo((int)Department.ComputerScience3 / 2);
            Assert.AreNotEqual(0, courseSelectingFormPresentationModel.GetCourseList((int)Department.ComputerScience3 / 2).Count);
        }

        //GetCourseListTest
        [TestMethod()]
        public void GetCourseListTest()
        {
            Assert.AreEqual(0, courseSelectingFormPresentationModel.GetCourseList((int)Department.ComputerScience3 / 2).Count);
            courseSelectingFormPresentationModel.UpdateCourseListInfo((int)Department.ComputerScience3 / 2);
            Assert.AreNotEqual(0, courseSelectingFormPresentationModel.GetCourseList((int)Department.ComputerScience3 / 2).Count);
        }

        //GetClassNameListTest
        [TestMethod()]
        public void GetClassNameListTest()
        {
            Assert.AreEqual(2, courseSelectingFormPresentationModel.GetClassNameList.Count());
        }

        //RemoveFromCourseListAndAddInToSelectedTabTest
        [TestMethod()]
        public void RemoveFromCourseListAndAddInToSelectedTabTest()
        {
            model.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            courseSelectingFormPresentationModel.AddSelectedCourse(windowsProgrammingCourseInfo);
            courseSelectingFormPresentationModel.RemoveFromCourseListAndAddInToSelectedTab((int)Department.ComputerScience3 / 2, 0);
            Assert.AreEqual(0, courseSelectingFormPresentationModel.GetCourseList((int)Department.ComputerScience3 / 2).Count);
            Assert.AreEqual(Tuple.Create(-2, (int)Department.ComputerScience3 / 2, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //ResetCheckButtonTest
        [TestMethod()]
        public void ResetCheckButtonTest()
        {
            courseSelectingFormPresentationModel.ClickCheckButton();
            courseSelectingFormPresentationModel.ResetCheckButton();
            Assert.IsTrue(courseSelectingFormPresentationModel.IsCheckButtonEnabled);
        }

        //ResetSubmitButtonTest
        [TestMethod()]
        public void ResetSubmitButtonTest()
        {
            courseSelectingFormPresentationModel.HasEnabledCheckBox();
            courseSelectingFormPresentationModel.ResetSubmitButton();
            Assert.IsFalse(courseSelectingFormPresentationModel.IsSubmitButtonEnabled);
        }

        //ClickCheckButtonTest
        [TestMethod()]
        public void ClickCheckButtonTest()
        {
            courseSelectingFormPresentationModel.ClickCheckButton();
            Assert.IsFalse(courseSelectingFormPresentationModel.IsCheckButtonEnabled);
        }

        //HasEnabledCheckBoxTest
        [TestMethod()]
        public void HasEnabledCheckBoxTest()
        {
            courseSelectingFormPresentationModel.HasEnabledCheckBox();
            Assert.IsTrue(courseSelectingFormPresentationModel.IsSubmitButtonEnabled);
        }

        //CheckCourseListTest
        [TestMethod()]
        public void CheckCourseListTest()
        {
            List<CourseInfo> checkCourseList = new List<CourseInfo>();
            List<CourseInfo> selectedCourseList = new List<CourseInfo>();
            checkCourseList.Add(windowsProgrammingCourseInfo);
            Assert.AreEqual("", courseSelectingFormPresentationModel.CheckCourseList(checkCourseList, selectedCourseList));
        }

        //AddSelectedCourseTest
        [TestMethod()]
        public void AddSelectedCourseTest()
        {
            courseSelectingFormPresentationModel.AddSelectedCourse(windowsProgrammingCourseInfo);
            Assert.AreEqual(1, courseSelectingFormPresentationModel.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, courseSelectingFormPresentationModel.GetSelectedCourseList[0]);
        }

        //FinishLoadComputerScienceCourseTabButtonTest
        [TestMethod()]
        public void FinishLoadComputerScienceCourseTabButtonTest()
        {
            courseSelectingFormPresentationModel.FinishLoadComputerScienceCourseTabButton();
            Assert.IsFalse(courseSelectingFormPresentationModel.IsLoadComputerScienceCourseTab);
        }

        //WaitSecondsTest
        [TestMethod()]
        public void WaitSecondsTest()
        {
            DateTime now = DateTime.Now;
            courseSelectingFormPresentationModel.WaitSeconds(1);
            Assert.AreEqual(DateTime.Now.Second, now.AddSeconds(1).Second);
        }

        //WaitSecondsTestFail
        [TestMethod()]
        public void WaitSecondsTestFail()
        {
            DateTime now = DateTime.Now;
            courseSelectingFormPresentationModel.WaitSeconds(0);
            Assert.AreEqual(DateTime.Now.Second, now.Second);
        }

        //ReloadAllFormTest
        [TestMethod()]
        public void ReloadAllFormTest()
        {
            bool isNotifyObserverWork = false;
            courseSelectingFormPresentationModel.ReloadAllForm();
            Assert.IsFalse(isNotifyObserverWork);
            courseSelectingFormPresentationModel._presentationModelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            courseSelectingFormPresentationModel.ReloadAllForm();
            Assert.IsTrue(isNotifyObserverWork);
        }

        //NotifyObserverTest
        [TestMethod()]
        public void NotifyObserverTest()
        {
            bool isNotifyObserverWork = false;
            courseSelectingFormPresentationModel._presentationModelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            courseSelectingFormPresentationModel.NotifyObserver();
            Assert.IsTrue(isNotifyObserverWork);
        }
    }
}