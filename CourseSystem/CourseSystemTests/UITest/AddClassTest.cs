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
    public class AddClassTest
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

        //AddClassTestLoadSuccessfully
        [TestMethod]
        public void AddClassTestLoadSuccessfully()
        {
            _robot.ClickButton("Course Selecting System");
            _robot.ClickButton("Course Management System");
            _robot.SwitchTo("CourseManagementForm");
            _robot.ClickTabControl("班級管理");
            _robot.ClickListBox("資工三");
            _robot.AssertText("_classNameTextBox", "資工三");
        }

        //AddClassTestAddSuccessfully
        [TestMethod]
        public void AddClassTestAddSuccessfully()
        {
            _robot.ClickButton("Course Selecting System");
            _robot.ClickButton("Course Management System");
            _robot.SwitchTo("CourseManagementForm");
            _robot.ClickTabControl("班級管理");
            _robot.ClickButton("新增班級");
            _robot.TypeTextBox("_classNameTextBox", "電資三");
            _robot.ClickButton("新增");
            _robot.AssertTextByName("電資三", "電資三");

            _robot.SwitchTo("CourseSelectingForm");
            _robot.ClickTabControl("電資三");
            _robot.AssertDataGridViewRowCountBy("_courseDataGridView", 0);
        }
    }
}
