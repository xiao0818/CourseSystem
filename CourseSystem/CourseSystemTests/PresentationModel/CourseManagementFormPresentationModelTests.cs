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
    public class CourseManagementFormPresentationModelTests
    {
        CourseManagementFormPresentationModel courseManagementFormPresentationModel;
        PresentationModel presentationModel;
        Model model;
        CourseInfo windowsProgrammingCourseInfo = new CourseInfo("291710", "視窗程式設計", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "3 4 6", "", "", "二教206(e)\n二教205(e)", "43", "15", "", "", "", "查詢", "", "");
        CourseInfo modifyCourseInfo = new CourseInfo("012345", "abcdefg", "1", "3.0", "3", "★", "陳偉凱", "", "", "", "", "", "", "", "二教206(e)\n二教205(e)", "43", "15", "", "", "", "查詢", "", "");

        //Initialize
        [TestInitialize]
        public void SetUp()
        {
            model = new Model();
            presentationModel = new PresentationModel(model);
            courseManagementFormPresentationModel = new CourseManagementFormPresentationModel(presentationModel);
        }

        //CourseManagementFormPresentationModelTest
        [TestMethod()]
        public void CourseManagementFormPresentationModelTest()
        {
            Assert.IsTrue(courseManagementFormPresentationModel.IsAddCourseDataButton);
            Assert.IsFalse(courseManagementFormPresentationModel.IsSaveCourseDataButton);
            Assert.IsTrue(courseManagementFormPresentationModel.IsLoadComputerScienceCourseButton);
        }

        //GetCourseInfoBySelectedIndexTest
        [TestMethod()]
        public void GetCourseInfoBySelectedIndexTest()
        {
            courseManagementFormPresentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(windowsProgrammingCourseInfo, courseManagementFormPresentationModel.GetCourseInfoBySelectedIndex(0));
        }

        //GetCourseDepartmentBySelectedIndexTest
        [TestMethod()]
        public void GetCourseDepartmentBySelectedIndexTest()
        {
            courseManagementFormPresentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(Tuple.Create((int)Department.ComputerScience3, (int)Department.ComputerScience3, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //AddIntoNotEnabledCourseListAndCourseTabTest
        [TestMethod()]
        public void AddIntoNotEnabledCourseListAndCourseTabTest()
        {
            courseManagementFormPresentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(windowsProgrammingCourseInfo, courseManagementFormPresentationModel.GetNotEnabledCourseList[0]);
            Assert.AreEqual(Tuple.Create(-1, (int)Department.ComputerScience3, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //AddIntoCourseListTest
        [TestMethod()]
        public void AddIntoCourseListTest()
        {
            courseManagementFormPresentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            Assert.AreEqual(windowsProgrammingCourseInfo, courseManagementFormPresentationModel.GetCourseListCollection[(int)Department.ComputerScience3][0]);
            Assert.AreEqual(Tuple.Create((int)Department.ComputerScience3, (int)Department.ComputerScience3, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(0));
        }

        //ResetAllButtonTest
        [TestMethod()]
        public void ResetAllButtonTest()
        {
            courseManagementFormPresentationModel.ChangeContentEnabled();
            courseManagementFormPresentationModel.ClickLoadComputerScienceCourseTabButton();
            courseManagementFormPresentationModel.ResetAllButton();
            Assert.IsTrue(courseManagementFormPresentationModel.IsAddCourseDataButton);
            Assert.IsFalse(courseManagementFormPresentationModel.IsSaveCourseDataButton);
            Assert.IsTrue(courseManagementFormPresentationModel.IsLoadComputerScienceCourseButton);
        }

        //SelectListBoxTest
        [TestMethod()]
        public void SelectListBoxTest()
        {
            courseManagementFormPresentationModel.SelectListBox();
            Assert.IsTrue(courseManagementFormPresentationModel.IsAddCourseDataButton);
            Assert.IsFalse(courseManagementFormPresentationModel.IsSaveCourseDataButton);
        }

        //ClickAddButtonTest
        [TestMethod()]
        public void ClickAddButtonTest()
        {
            courseManagementFormPresentationModel.ClickAddButton();
            Assert.IsFalse(courseManagementFormPresentationModel.IsAddCourseDataButton);
            Assert.IsFalse(courseManagementFormPresentationModel.IsSaveCourseDataButton);
        }

        //ChangeContentEnabledTest
        [TestMethod()]
        public void ChangeContentEnabledTest()
        {
            courseManagementFormPresentationModel.ChangeContentEnabled();
            Assert.IsTrue(courseManagementFormPresentationModel.IsSaveCourseDataButton);
        }

        //ChangeContentNotEnabledTest
        [TestMethod()]
        public void ChangeContentNotEnabledTest()
        {
            courseManagementFormPresentationModel.ChangeContentNotEnabled();
            Assert.IsFalse(courseManagementFormPresentationModel.IsSaveCourseDataButton);
        }

        //SaveModifyCourseMainForEnabledOneTest
        [TestMethod()]
        public void SaveModifyCourseMainForEnabledOneTest()
        {
            courseManagementFormPresentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForEnabled(Tuple.Create((int)Department.ComputerScience3 / 2, (int)Department.ComputerScience3, 0), modifyCourseInfo, windowsProgrammingCourseInfo, (int)Department.ElectronicEngineering3 / 2);
            Assert.AreEqual(0, courseManagementFormPresentationModel.GetCourseListCollection[(int)Department.ComputerScience3 / 2].Count());
            Assert.AreEqual(modifyCourseInfo, courseManagementFormPresentationModel.GetCourseListCollection[(int)Department.ElectronicEngineering3 / 2][0]);
            Assert.AreEqual(1, courseManagementFormPresentationModel.GetCourseListCollection[(int)Department.ElectronicEngineering3 / 2].Count());
            Assert.AreEqual(Tuple.Create((int)Department.ElectronicEngineering3 / 2, (int)Department.ElectronicEngineering3 / 2, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(0));
            Assert.AreEqual("編輯成功", message);
        }

        //SaveModifyCourseMainForEnabledTwoSuccessTest
        [TestMethod()]
        public void SaveModifyCourseMainForEnabledTwoSuccessTest()
        {
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            presentationModel.AddIntoSelectedCourseListAndCourseTab(modifyCourseInfo, (int)Department.ComputerScience3);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForEnabled(Tuple.Create(-2, (int)Department.ComputerScience3, 1), modifyCourseInfo, modifyCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(modifyCourseInfo, presentationModel.GetSelectedCourseList[1]);
            Assert.AreEqual(2, presentationModel.GetSelectedCourseList.Count());
            Assert.AreEqual(Tuple.Create(-2, (int)Department.ComputerScience3, 1), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(1));
            Assert.AreEqual("編輯成功", message);
        }

        //SaveModifyCourseMainForEnabledTwoFailTest
        [TestMethod()]
        public void SaveModifyCourseMainForEnabledTwoFailTest()
        {
            courseManagementFormPresentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            presentationModel.AddIntoSelectedCourseListAndCourseTab(modifyCourseInfo, (int)Department.ComputerScience3);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForEnabled(Tuple.Create(-2, (int)Department.ComputerScience3, 1), windowsProgrammingCourseInfo, modifyCourseInfo, (int)Department.ElectronicEngineering3 / 2);
            Assert.AreEqual(modifyCourseInfo, presentationModel.GetSelectedCourseList[1]);
            Assert.AreEqual(2, presentationModel.GetSelectedCourseList.Count());
            Assert.AreEqual(Tuple.Create(-2, (int)Department.ComputerScience3, 1), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(1));
            Assert.AreEqual("編輯失敗\n此編輯會導致已選課程發生:\n課號相同:「291710 視窗程式設計」\n課程名稱相同:「291710 視窗程式設計」\n衝堂:「291710 視窗程式設計」", message);
        }

        //SaveModifyCourseMainForEnabledThreeForUnselectedTest
        [TestMethod()]
        public void SaveModifyCourseMainForEnabledThreeForUnselectedTest()
        {
            courseManagementFormPresentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForEnabled(Tuple.Create(-1, (int)Department.ComputerScience3, 0), windowsProgrammingCourseInfo, windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(0, courseManagementFormPresentationModel.GetNotEnabledCourseList.Count());
            Assert.AreEqual(windowsProgrammingCourseInfo, courseManagementFormPresentationModel.GetCourseListCollection[(int)Department.ComputerScience3][0]);
            Assert.AreEqual(1, courseManagementFormPresentationModel.GetCourseListCollection[(int)Department.ComputerScience3].Count());
            Assert.AreEqual(Tuple.Create((int)Department.ComputerScience3, (int)Department.ComputerScience3, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(0));
            Assert.AreEqual("編輯成功", message);
        }

        //SaveModifyCourseMainForEnabledThreeForSelectedSuccessTest
        [TestMethod()]
        public void SaveModifyCourseMainForEnabledThreeForSelectedSuccessTest()
        {
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            courseManagementFormPresentationModel.AddIntoNotEnabledCourseListAndCourseTab(modifyCourseInfo, (int)Department.SelectedComputerScience3);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForEnabled(Tuple.Create(-1, (int)Department.SelectedComputerScience3, 0), modifyCourseInfo, modifyCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(0, courseManagementFormPresentationModel.GetNotEnabledCourseList.Count);
            Assert.AreEqual(modifyCourseInfo, courseManagementFormPresentationModel.GetSelectedCourseList[1]);
            Assert.AreEqual(2, courseManagementFormPresentationModel.GetSelectedCourseList.Count);
            Assert.AreEqual(Tuple.Create(-2, (int)Department.ComputerScience3, 1), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(1));
            Assert.AreEqual("編輯成功", message);
        }

        //SaveModifyCourseMainForEnabledThreeForSelectedFailTest
        [TestMethod()]
        public void SaveModifyCourseMainForEnabledThreeForSelectedFailTest()
        {
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            courseManagementFormPresentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.SelectedComputerScience3);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForEnabled(Tuple.Create(-1, (int)Department.SelectedComputerScience3, 0), windowsProgrammingCourseInfo, windowsProgrammingCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(1, courseManagementFormPresentationModel.GetSelectedCourseList.Count);
            Assert.AreEqual(1, courseManagementFormPresentationModel.GetNotEnabledCourseList.Count);
            Assert.AreEqual(windowsProgrammingCourseInfo, courseManagementFormPresentationModel.GetNotEnabledCourseList[0]);
            Assert.AreEqual(Tuple.Create(-1, (int)Department.SelectedComputerScience3, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(1));
            Assert.AreEqual("編輯失敗\n此編輯會導致已選課程發生:\n課號相同:「291710 視窗程式設計」\n課程名稱相同:「291710 視窗程式設計」\n衝堂:「291710 視窗程式設計」", message);
        }

        //SaveModifyCourseMainForNotEnabledFourTest
        [TestMethod()]
        public void SaveModifyCourseMainForNotEnabledFourTest()
        {
            courseManagementFormPresentationModel.AddIntoCourseList(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForNotEnabled(Tuple.Create((int)Department.ComputerScience3, (int)Department.ComputerScience3, 0), modifyCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(0, courseManagementFormPresentationModel.GetCourseListCollection[(int)Department.ComputerScience3].Count());
            Assert.AreEqual(modifyCourseInfo, courseManagementFormPresentationModel.GetNotEnabledCourseList[0]);
            Assert.AreEqual(1, courseManagementFormPresentationModel.GetNotEnabledCourseList.Count());
            Assert.AreEqual(Tuple.Create(-1, (int)Department.ComputerScience3, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(0));
            Assert.AreEqual("編輯成功", message);
        }

        //SaveModifyCourseMainForNotEnabledFiveTest
        [TestMethod()]
        public void SaveModifyCourseMainForNotEnabledFiveTest()
        {
            presentationModel.AddIntoSelectedCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForNotEnabled(Tuple.Create(-2, (int)Department.ComputerScience3, 0), modifyCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(0, courseManagementFormPresentationModel.GetSelectedCourseList.Count());
            Assert.AreEqual(modifyCourseInfo, courseManagementFormPresentationModel.GetNotEnabledCourseList[0]);
            Assert.AreEqual(1, courseManagementFormPresentationModel.GetNotEnabledCourseList.Count());
            Assert.AreEqual(Tuple.Create(-1, (int)Department.SelectedComputerScience3, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(0));
            Assert.AreEqual("編輯成功", message);
        }

        //SaveModifyCourseMainForNotEnabledSixForEnabledCourseSixTest
        [TestMethod()]
        public void SaveModifyCourseMainForNotEnabledSixForEnabledCourseSixTest()
        {
            courseManagementFormPresentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.ComputerScience3);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForNotEnabled(Tuple.Create(-1, (int)Department.ComputerScience3, 0), modifyCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(modifyCourseInfo, courseManagementFormPresentationModel.GetNotEnabledCourseList[0]);
            Assert.AreEqual(1, courseManagementFormPresentationModel.GetNotEnabledCourseList.Count());
            Assert.AreEqual(Tuple.Create(-1, (int)Department.ComputerScience3, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(0));
            Assert.AreEqual("編輯成功", message);
        }

        //SaveModifyCourseMainForNotEnabledSixForNotEnabledCourseSixTest
        [TestMethod()]
        public void SaveModifyCourseMainForNotEnabledSixForNotEnabledCourseSixTest()
        {
            courseManagementFormPresentationModel.AddIntoNotEnabledCourseListAndCourseTab(windowsProgrammingCourseInfo, (int)Department.SelectedComputerScience3);
            string message = courseManagementFormPresentationModel.SaveModifyCourseMainForNotEnabled(Tuple.Create(-1, (int)Department.SelectedComputerScience3, 0), modifyCourseInfo, (int)Department.ComputerScience3 / 2);
            Assert.AreEqual(modifyCourseInfo, courseManagementFormPresentationModel.GetNotEnabledCourseList[0]);
            Assert.AreEqual(1, courseManagementFormPresentationModel.GetNotEnabledCourseList.Count());
            Assert.AreEqual(Tuple.Create(-1, (int)Department.SelectedComputerScience3, 0), courseManagementFormPresentationModel.GetCourseDepartmentBySelectedIndex(0));
            Assert.AreEqual("編輯成功", message);
        }

        //ClickLoadComputerScienceCourseTabButtonTest
        [TestMethod()]
        public void ClickLoadComputerScienceCourseTabButtonTest()
        {
            courseManagementFormPresentationModel.ClickLoadComputerScienceCourseTabButton();
            Assert.IsFalse(courseManagementFormPresentationModel.IsLoadComputerScienceCourseButton);
        }

        //FinishLoadComputerScienceCourseTest
        [TestMethod()]
        public void FinishLoadComputerScienceCourseTest()
        {
            courseManagementFormPresentationModel.ClickLoadComputerScienceCourseTabButton();
            courseManagementFormPresentationModel.FinishLoadComputerScienceCourse();
            Assert.IsTrue(courseManagementFormPresentationModel.IsLoadComputerScienceCourseButton);
        }

        //ReloadAllFormTest
        [TestMethod()]
        public void ReloadAllFormTest()
        {
            bool isNotifyObserverWork = false;
            courseManagementFormPresentationModel._presentationModelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            courseManagementFormPresentationModel.ReloadAllForm();
            Assert.IsTrue(isNotifyObserverWork);
        }

        //NotifyObserverTest
        [TestMethod()]
        public void NotifyObserverTest()
        {
            bool isNotifyObserverWork = false;
            courseManagementFormPresentationModel._presentationModelChanged += () =>
            {
                isNotifyObserverWork = true;
            };
            courseManagementFormPresentationModel.NotifyObserver();
            Assert.IsTrue(isNotifyObserverWork);
        }
    }
}