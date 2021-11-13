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
    public class StartUpFormPresentationModelTests
    {
        StartUpFormPresentationModel startUpFormPresentationModel;
        
        //Initialize
        [TestInitialize]
        public void SetUp()
        {
            startUpFormPresentationModel = new StartUpFormPresentationModel();
        }

        //StartUpFormPresentationModelTest
        [TestMethod()]
        public void StartUpFormPresentationModelTest()
        {
            Assert.IsTrue(startUpFormPresentationModel.IsCourseSelectingFormButtonEnabled);
            Assert.IsTrue(startUpFormPresentationModel.IsCourseManagementFormButtonEnabled);
        }

        //ClickCourseSelectingFormButtonTest
        [TestMethod()]
        public void ClickCourseSelectingFormButtonTest()
        {
            startUpFormPresentationModel.ClickCourseSelectingFormButton();
            Assert.IsFalse(startUpFormPresentationModel.IsCourseSelectingFormButtonEnabled);
        }

        //ClickCourseManagementFormButtonTest
        [TestMethod()]
        public void ClickCourseManagementFormButtonTest()
        {
            startUpFormPresentationModel.ClickCourseManagementFormButton();
            Assert.IsFalse(startUpFormPresentationModel.IsCourseManagementFormButtonEnabled);
        }

        //ResetCourseSelectingFormButtonTest
        [TestMethod()]
        public void ResetCourseSelectingFormButtonTest()
        {
            startUpFormPresentationModel.ResetCourseSelectingFormButton();
            Assert.IsTrue(startUpFormPresentationModel.IsCourseSelectingFormButtonEnabled);
        }

        //ResetCourseManagementFormButtonTest
        [TestMethod()]
        public void ResetCourseManagementFormButtonTest()
        {
            startUpFormPresentationModel.ResetCourseManagementFormButton();
            Assert.IsTrue(startUpFormPresentationModel.IsCourseManagementFormButtonEnabled);
        }
    }
}