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
    public class ImportCourseProgressFormPresentationModelTests
    {
        ImportCourseProgressFormPresentationModel importCourseProgressFormPresentationModel;
        PresentationModel presentationModel;
        Model model;

        //Initialize
        [TestInitialize]
        public void SetUp()
        {
            model = new Model();
            presentationModel = new PresentationModel(model);
            importCourseProgressFormPresentationModel = new ImportCourseProgressFormPresentationModel(presentationModel);
        }

        ////ImportCourseProgressFormPresentationModelTest
        //[TestMethod()]
        //public void ImportCourseProgressFormPresentationModelTest()
        //{
        //    Assert.Fail();
        //}

        //ClickLoadComputerScienceCourseTabButtonTest
        [TestMethod()]
        public void ClickLoadComputerScienceCourseTabButtonTest()
        {
            importCourseProgressFormPresentationModel.ClickLoadComputerScienceCourseTabButton();
            Assert.IsTrue(presentationModel.IsLoadComputerScienceCourseTab);
        }

        //WaitSecondsTest
        [TestMethod()]
        public void WaitSecondsTest()
        {
            DateTime now = DateTime.Now;
            importCourseProgressFormPresentationModel.WaitSeconds(1);
            Assert.AreEqual(DateTime.Now.Second, now.AddSeconds(1).Second);
        }

        //WaitSecondsTestFail
        [TestMethod()]
        public void WaitSecondsTestFail()
        {
            DateTime now = DateTime.Now;
            importCourseProgressFormPresentationModel.WaitSeconds(0);
            Assert.AreEqual(DateTime.Now.Second, now.Second);
        }

        //NotifyObserverTest
        [TestMethod()]
        public void NotifyObserverTest()
        {
            bool isNotifyObserverWork = false;
            importCourseProgressFormPresentationModel._presentationModelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            importCourseProgressFormPresentationModel.NotifyObserver();
            Assert.IsTrue(isNotifyObserverWork);
        }
    }
}