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
    public class CourseSelectionResultFormPresentationModelTests
    {
        CourseSelectionResultFormPresentationModel courseSelectionResultFormPresentationModel;
        PresentationModel presentationModel;
        Model model;
        CourseInfo windowsProgrammingCourseInfo = new CourseInfo("291710", "視窗程式設計", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "3 4 6", "", "", "二教206(e)\n二教205(e)", "43", "15", "", "", "", "查詢", "", "");

        //Initialize
        [TestInitialize]
        public void SetUp()
        {
            model = new Model();
            presentationModel = new PresentationModel(model);
            courseSelectionResultFormPresentationModel = new CourseSelectionResultFormPresentationModel(presentationModel);
        }

        ////CourseSelectionResultFormPresentationModelTest
        //[TestMethod()]
        //public void CourseSelectionResultFormPresentationModelTest()
        //{
        //    Assert.Fail();
        //}

        //RemoveCourseFromSelectionResultTest
        [TestMethod()]
        public void RemoveCourseFromSelectionResultTest()
        {
            model.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            courseSelectionResultFormPresentationModel.RemoveCourseFromSelectionResult(0);
            Assert.AreEqual(0, courseSelectionResultFormPresentationModel.GetSelectedCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, model.GetCourseList((int)Department.ComputerScience3)[0]);
            Assert.AreEqual(Tuple.Create((int)ListName.ComputerScience3, (int)Department.ComputerScience3, 0), presentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //ReloadAllFormTest
        [TestMethod()]
        public void ReloadAllFormTest()
        {
            bool isNotifyObserverWork = false;
            courseSelectionResultFormPresentationModel._presentationModelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            courseSelectionResultFormPresentationModel.ReloadAllForm();
            Assert.IsTrue(isNotifyObserverWork);
        }

        //NotifyObserverTest
        [TestMethod()]
        public void NotifyObserverTest()
        {
            bool isNotifyObserverWork = false;
            courseSelectionResultFormPresentationModel._presentationModelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            courseSelectionResultFormPresentationModel.NotifyObserver();
            Assert.IsTrue(isNotifyObserverWork);
        }
    }
}