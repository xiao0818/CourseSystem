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
            Assert.Fail();
        }

        //GetCourseListTest
        [TestMethod()]
        public void GetCourseListTest()
        {
            Assert.Fail();
        }

        //RemoveFromCourseListAndAddInToSelectedTabTest
        [TestMethod()]
        public void RemoveFromCourseListAndAddInToSelectedTabTest()
        {
            Assert.Fail();
        }

        //RemoveCourseFromCourseListTest
        [TestMethod()]
        public void RemoveCourseFromCourseListTest()
        {
            Assert.Fail();
        }

        //RemoveCourseFromSelectionResultTest
        [TestMethod()]
        public void RemoveCourseFromSelectionResultTest()
        {
            Assert.Fail();
        }

        //RemoveCourseFromSelectedListTest
        [TestMethod()]
        public void RemoveCourseFromSelectedListTest()
        {
            Assert.Fail();
        }

        //GetCourseInfoBySelectedIndexTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexTest()
        {
            Assert.Fail();
        }

        //GetCourseDepartmentBySelectedIndexTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexTest()
        {
            Assert.Fail();
        }

        //AddIntoSelectedCourseListAndCourseTabTest
        [TestMethod()]
        public void AddIntoSelectedCourseListAndCourseTabTest()
        {
            Assert.Fail();
        }

        //AddIntoNotEnabledCourseListAndCourseTabTest
        [TestMethod()]
        public void AddIntoNotEnabledCourseListAndCourseTabTest()
        {
            Assert.Fail();
        }

        //AddIntoCourseListTest
        [TestMethod()]
        public void AddIntoCourseListTest()
        {
            Assert.Fail();
        }

        //RemoveCourseFromSelectedTabDictionaryTest
        [TestMethod()]
        public void RemoveCourseFromSelectedTabDictionaryTest()
        {
            Assert.Fail();
        }

        //RemoveCourseFromNotEnabledTabDictionaryTest
        [TestMethod()]
        public void RemoveCourseFromNotEnabledTabDictionaryTest()
        {
            Assert.Fail();
        }

        //AddSelectedCourseTest
        [TestMethod()]
        public void AddSelectedCourseTest()
        {
            Assert.Fail();
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