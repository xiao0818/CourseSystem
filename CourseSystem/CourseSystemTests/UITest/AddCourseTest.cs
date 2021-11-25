using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystemTests
{
    [TestClass()]
    public class AddCourseTest
    {
        Robot _robot;
        private string targetAppPath;
        private const string START_UP_FORM = "StartUpForm";

        //Initialize
        [TestInitialize]
        public void SetUp()
        {
            var projectName = "CourseSystem";
            string solutionPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            targetAppPath = Path.Combine(solutionPath, projectName, "bin", "Debug", "CourseSystem.exe");
            _robot = new Robot(targetAppPath, START_UP_FORM);

            _robot.ClickButton("Course Selecting System");
            _robot.ClickButton("Course Management System");
            _robot.SwitchTo("CourseManagementForm");
        }

        //TearDown
        [TestCleanup]
        public void TearDown()
        {
            _robot.CleanUp();
        }

        //AddCourseTestSuccessfully
        [TestMethod]
        public void AddCourseTestSuccessfully()
        {
            _robot.ClickButton("新增課程");
            _robot.AssertText("_saveCourseDataButton", "新增");
            _robot.AssertText("_courseDataGroupBox", "新增課程");
            _robot.AssertEnableById("_saveCourseDataButton", false);
            _robot.AssertEnableById("_addCourseDataButton", false);

            _robot.TypeTextBox("_courseNumberTextBox", "123456");
            _robot.TypeTextBox("_courseNameTextBox", "叮叮咚咚");
            _robot.TypeTextBox("_courseStageTextBox", "1");
            _robot.TypeTextBox("_courseCreditTextBox", "1.0");
            _robot.TypeTextBox("_courseTeacherTextBox", "叮咚");
            _robot.ClickDataGridViewCellBy("_courseTimeDataGridView", 4, "六");
            _robot.AssertEnableById("_saveCourseDataButton", true);
            _robot.ClickButton("新增");
            _robot.CloseMessageBox();

            _robot.AssertTextByName("叮叮咚咚", "叮叮咚咚");
        }
    }
}
