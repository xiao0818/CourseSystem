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
    public class AddAllComputerScienceCourseTest
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

        //AddAllComputerScienceCourseTestSuccessfully
        [TestMethod]
        public void AddAllComputerScienceCourseTestSuccessfully()
        {
            _robot.ClickButton("匯入資工系\n全部課程");
            _robot.Sleep(10);

            _robot.SwitchTo("CourseSelectingForm");
            _robot.ClickTabControl("資工三");
            _robot.AssertDataGridViewRowCountNotEmpty("_courseDataGridView");
            _robot.ClickTabControl("資工一");
            _robot.AssertDataGridViewRowCountNotEmpty("_courseDataGridView");
            _robot.ClickTabControl("資工二");
            _robot.AssertDataGridViewRowCountNotEmpty("_courseDataGridView");
            _robot.ClickTabControl("資工四");
            _robot.AssertDataGridViewRowCountNotEmpty("_courseDataGridView");
            _robot.ClickTabControl("資工所");
            _robot.AssertDataGridViewRowCountNotEmpty("_courseDataGridView");
        }
    }
}
