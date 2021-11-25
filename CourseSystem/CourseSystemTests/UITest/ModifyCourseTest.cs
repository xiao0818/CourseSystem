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
    public class ModifyCourseTest
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
        }

        //TearDown
        [TestCleanup]
        public void TearDown()
        {
            _robot.CleanUp();
        }

        //ModifyCourseTestForChangeTextContent
        [TestMethod]
        public void ModifyCourseTestForChangeTextContent()
        {
            _robot.SwitchTo("CourseManagementForm");
            _robot.ClickListBox("視窗程式設計");
            _robot.TypeTextBox("_courseNumberTextBox", "123456");
            _robot.AssertEnableById("_saveCourseDataButton", true);
            _robot.TypeTextBox("_courseNumberTextBox", "");
            _robot.AssertEnableById("_saveCourseDataButton", false);
        }

        //ModifyCourseTestForChangeClassTime
        [TestMethod]
        public void ModifyCourseTestForChangeClassTime()
        {
            _robot.SwitchTo("CourseManagementForm");
            _robot.ClickListBox("視窗程式設計");
            _robot.ClickDataGridViewCellBy("_courseTimeDataGridView", 6, "四");
            _robot.ClickDataGridViewCellBy("_courseTimeDataGridView", 5, "四");
            _robot.AssertEnableById("_saveCourseDataButton", true);
            _robot.ClickDataGridViewCellBy("_courseTimeDataGridView", 6, "四");
            _robot.AssertEnableById("_saveCourseDataButton", false);
        }

        //ModifyCourseTestForSavingWithoutSelected
        [TestMethod]
        public void ModifyCourseTestForSavingWithoutSelected()
        {
            _robot.SwitchTo("CourseSelectingForm");
            _robot.ClickButton("查看選課結果");
            string[] windowsProgramming = _robot.GetDataGridViewRowDataBy("_courseDataGridView", 8);
            string[] bigDataAnalize = _robot.GetDataGridViewRowDataBy("_courseDataGridView", 9);
            int computerScienceCount = _robot.GetDataGridViewRowCountBy("_courseDataGridView");
            _robot.ClickTabControl("電子三甲");
            string[] computerNetwork = _robot.GetDataGridViewRowDataBy("_courseDataGridView", 1);
            int electronicEngineeringCount = _robot.GetDataGridViewRowCountBy("_courseDataGridView");
            _robot.SwitchTo("CourseManagementForm");

            ModifyWindowsProgrammingCourseData(windowsProgramming);

            _robot.SwitchTo("CourseSelectingForm");
            _robot.ClickTabControl("資工三");
            _robot.AssertDataGridViewRowDataBy("_courseDataGridView", 8, bigDataAnalize);
            _robot.AssertDataGridViewRowCountBy("_courseDataGridView", computerScienceCount - 1);

            _robot.ClickTabControl("電子三甲");
            _robot.AssertDataGridViewRowDataBy("_courseDataGridView", 1, windowsProgramming);
            _robot.AssertDataGridViewRowDataBy("_courseDataGridView", 2, computerNetwork);
            _robot.AssertDataGridViewRowCountBy("_courseDataGridView", electronicEngineeringCount + 1);
        }

        //ModifyCourseTestForSavingWithSelected
        [TestMethod]
        public void ModifyCourseTestForSavingWithSelected()
        {
            _robot.SwitchTo("CourseSelectingForm");
            _robot.ClickButton("查看選課結果");
            string[] windowsProgramming = _robot.GetDataGridViewRowDataBy("_courseDataGridView", 8);
            _robot.ClickDataGridViewCellBy("_courseDataGridView", 8, "選");
            _robot.ClickButton("確認送出");
            _robot.CloseMessageBox();
            _robot.SwitchTo("CourseManagementForm");

            _robot.RollDown(8);
            ModifyWindowsProgrammingCourseData(windowsProgramming);

            _robot.SwitchTo("CourseSelectionResultForm");
            windowsProgramming[0] = "退選";
            _robot.AssertDataGridViewRowDataBy("_courseResultDataGridView", 0, windowsProgramming);
            _robot.AssertDataGridViewRowCountBy("_courseResultDataGridView", 1);
        }

        //Modify
        private string[] ModifyWindowsProgrammingCourseData(string[] windowsProgramming)
        {
            _robot.ClickListBox("視窗程式設計");
            _robot.TypeTextBox("_courseNumberTextBox", "270915");
            _robot.TypeTextBox("_courseNameTextBox", "物件導向分析與設計");
            _robot.TypeTextBox("_courseCreditTextBox", "2");
            _robot.ClickGroupBox("時數(*)", "2");
            _robot.ClickGroupBox("班級(*)", "電子三甲");
            _robot.ClickDataGridViewCellBy("_courseTimeDataGridView", 2, "四");
            _robot.ClickDataGridViewCellBy("_courseTimeDataGridView", 3, "四");
            _robot.ClickDataGridViewCellBy("_courseTimeDataGridView", 6, "四");
            _robot.ClickDataGridViewCellBy("_courseTimeDataGridView", 2, "一");
            _robot.ClickDataGridViewCellBy("_courseTimeDataGridView", 2, "二");
            _robot.ClickButton("儲存");
            _robot.CloseMessageBox();
            windowsProgramming[1] = "270915";
            windowsProgramming[2] = "物件導向分析與設計";
            windowsProgramming[4] = "2";
            windowsProgramming[5] = "2";
            windowsProgramming[9] = "3";
            windowsProgramming[10] = "3";
            windowsProgramming[12] = "";
            _robot.AssertTextByName("物件導向分析與設計", "物件導向分析與設計");
            return windowsProgramming;
        }
    }
}
