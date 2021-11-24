﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystemTests
{
    [TestClass()]
    public class UITest
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
        }

        //TearDown
        [TestCleanup]
        public void TearDown()
        {
            _robot.CleanUp();
        }

        //ClickCourseSelectingTest
        [TestMethod]
        public void ClickCourseSelectingTest()
        {
            _robot.ClickButton("Course Selecting System");
            _robot.SwitchTo("CourseSelectingForm");
            _robot.ClickButton("查看選課結果");

            string[] windowsProgramming = _robot.GetDataGridViewRowDataBy("_courseDataGridView", 8);
            string[] bigDataAnalize = _robot.GetDataGridViewRowDataBy("_courseDataGridView", 9);
            int computerScienceCount = _robot.GetDataGridViewRowCountBy("_courseDataGridView");
            _robot.AssertDataGridViewRowDataBy("_courseDataGridView", 8, windowsProgramming);
            _robot.AssertDataGridViewRowCountBy("_courseDataGridView", computerScienceCount);
            _robot.ClickDataGridViewCellBy("_courseDataGridView", 8, "選");
            _robot.ClickButton("確認送出");
            _robot.CloseMessageBox();
            _robot.AssertDataGridViewRowDataBy("_courseDataGridView", 8, bigDataAnalize);
            _robot.AssertDataGridViewRowCountBy("_courseDataGridView", computerScienceCount - 1);

            _robot.ClickTabControl("電子三甲");
            string[] computerNetwork = _robot.GetDataGridViewRowDataBy("_courseDataGridView", 1);
            string[] digitalVideoProcess = _robot.GetDataGridViewRowDataBy("_courseDataGridView", 2);
            int electronicEngineeringCount = _robot.GetDataGridViewRowCountBy("_courseDataGridView");
            _robot.AssertDataGridViewRowDataBy("_courseDataGridView", 1, computerNetwork);
            _robot.AssertDataGridViewRowCountBy("_courseDataGridView", electronicEngineeringCount);
            _robot.ClickDataGridViewCellBy("_courseDataGridView", 1, "選");
            _robot.ClickButton("確認送出");
            _robot.CloseMessageBox();
            _robot.AssertDataGridViewRowDataBy("_courseDataGridView", 1, digitalVideoProcess);
            _robot.AssertDataGridViewRowCountBy("_courseDataGridView", electronicEngineeringCount - 1);

            _robot.SwitchTo("CourseSelectionResultForm");
            windowsProgramming[0] = "退選";
            computerNetwork[0] = "退選";
            _robot.AssertDataGridViewRowDataBy("_courseResultDataGridView", 1, windowsProgramming);
            _robot.AssertDataGridViewRowDataBy("_courseResultDataGridView", 0, computerNetwork);
            _robot.AssertDataGridViewRowCountBy("_courseResultDataGridView", 2);
            _robot.ClickButton("退 資料列 1");
            _robot.ClickButton("退 資料列 0");
            _robot.AssertDataGridViewRowCountBy("_courseResultDataGridView", 0);

            _robot.SwitchTo("CourseSelectingForm");
            _robot.ClickTabControl("資工三");
            windowsProgramming[0] = "False";
            _robot.AssertDataGridViewRowDataBy("_courseDataGridView", 8, windowsProgramming);
            _robot.AssertDataGridViewRowCountBy("_courseDataGridView", computerScienceCount);

            _robot.ClickTabControl("電子三甲");
            computerNetwork[0] = "False";
            _robot.AssertDataGridViewRowDataBy("_courseDataGridView", 1, computerNetwork);
            _robot.AssertDataGridViewRowCountBy("_courseDataGridView", electronicEngineeringCount);
        }
    }
}
