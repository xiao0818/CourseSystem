using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;
using System.Windows.Automation;
using System.Windows;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Windows.Input;
using System.Windows.Forms;

namespace CourseSystemTests
{
    public class Robot
    {
        private WindowsDriver<WindowsElement> _driver;
        private Dictionary<string, string> _windowHandles;
        private string _root;
        private const string CONTROL_NOT_FOUND_EXCEPTION = "The specific control is not found!!";
        private const string WIN_APP_DRIVER_URI = "http://127.0.0.1:4723";

        const string APPLICATION = "app";
        const string DEVICE_NAME = "deviceName";
        const string WINDOWS = "WindowsPC";
        const string CONTROL_TYPE_TAB_ITEM = "ControlType.TabItem";
        const string SEND_WAIT_KEYS = "%{F4}";
        const string ENTER = "確定";
        const string SPACE = " ";
        const string DATA_ROW = "資料列";
        const string DATA_GRID = "datagrid";
        const string PATH_SYMBOL = "//*";
        const string NULL = "(null)";
        const string NEXT_ROW = "下移一行";
        const int WAITING_SECONDS = 5;

        // constructor
        public Robot(string targetAppPath, string root)
        {
            this.Initialize(targetAppPath, root);
        }

        // initialize
        public void Initialize(string targetAppPath, string root)
        {
            _root = root;
            var options = new AppiumOptions();
            options.AddAdditionalCapability(APPLICATION, targetAppPath);
            options.AddAdditionalCapability(DEVICE_NAME, WINDOWS);
            _driver = new WindowsDriver<WindowsElement>(new Uri(WIN_APP_DRIVER_URI), options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WAITING_SECONDS);
            _windowHandles = new Dictionary<string, string>
            {
                {
                    _root, _driver.CurrentWindowHandle
                }
            };
        }

        // clean up
        public void CleanUp()
        {
            SwitchTo(_root);
            _driver.CloseApp();
            _driver.Dispose();
        }

        // test
        public void SwitchTo(string formId)
        {
            if (_windowHandles.ContainsKey(formId))
                _driver.SwitchTo().Window(_windowHandles[formId]);
            else
            {
                SwitchWithNotContain(formId);
            }
        }

        // test
        public void Sleep(Double time)
        {
            Thread.Sleep(TimeSpan.FromSeconds(time));
        }

        // test
        public void ClickButton(string name)
        {
            _driver.FindElementByName(name).Click();
        }

        // test
        public void ClickTabControl(string name)
        {
            var elements = _driver.FindElementsByName(name);
            foreach (var element in elements)
            {
                if (CONTROL_TYPE_TAB_ITEM == element.TagName)
                    element.Click();
            }
        }

        // test
        public void CloseWindow()
        {
            SendKeys.SendWait(SEND_WAIT_KEYS);
        }

        // test
        public void CloseMessageBox()
        {
            _driver.FindElementByName(ENTER).Click();
        }

        // test
        public void ClickDataGridViewCellBy(string id, int rowIndex, string columnName)
        {
            var dataGridView = _driver.FindElementByAccessibilityId(id);
            _driver.FindElementByName(columnName + SPACE + DATA_ROW + SPACE + rowIndex).Click();
        }

        // test
        public void AssertEnable(string name, bool state)
        {
            WindowsElement element = _driver.FindElementByName(name);
            Assert.AreEqual(state, element.Enabled);
        }

        // test
        public void AssertText(string id, string text)
        {
            WindowsElement element = _driver.FindElementByAccessibilityId(id);
            Assert.AreEqual(text, element.Text);
        }

        // test
        public void AssertDataGridViewRowDataBy(string id, int rowIndex, string[] data)
        {
            var dataGridView = _driver.FindElementByAccessibilityId(id);
            var rowDatas = dataGridView.FindElementByName(DATA_ROW + SPACE + rowIndex).FindElementsByXPath(PATH_SYMBOL);
            // FindElementsByXPath("//*") 會把 "row" node 也抓出來，因此 i 要從 1 開始以跳過 "row" node
            for (int i = 1; i < rowDatas.Count; i++)
                Assert.AreEqual(data[i - 1], rowDatas[i].Text.Replace(NULL, ""));
        }

        // test
        public void AssertDataGridViewRowCountBy(string id, int rowCount)
        {
            var dataGridView = _driver.FindElementByAccessibilityId(id);
            Point point = new Point(dataGridView.Location.X, dataGridView.Location.Y);
            AutomationElement element = AutomationElement.FromPoint(point);
            while (element != null && element.Current.LocalizedControlType.Contains(DATA_GRID) == false)
                element = TreeWalker.RawViewWalker.GetParent(element);
            if (element != null)
            {
                GridPattern gridPattern = element.GetCurrentPattern(GridPattern.Pattern) as GridPattern;
                if (gridPattern != null)
                    Assert.AreEqual(rowCount, gridPattern.Current.RowCount);
            }
        }

        // get
        public bool GetEnable(string name)
        {
            WindowsElement element = _driver.FindElementByName(name);
            return element.Enabled;
        }

        // get
        public string GetText(string id)
        {
            WindowsElement element = _driver.FindElementByAccessibilityId(id);
            return element.Text;
        }

        // get
        public string[] GetDataGridViewRowDataBy(string id, int rowIndex)
        {
            var dataGridView = _driver.FindElementByAccessibilityId(id);
            var rowDatas = dataGridView.FindElementByName(DATA_ROW + SPACE + rowIndex).FindElementsByXPath(PATH_SYMBOL);
            return TakeOutDataGridViewRowData(rowDatas);
        }

        // get
        public int GetDataGridViewRowCountBy(string id)
        {
            var dataGridView = _driver.FindElementByAccessibilityId(id);
            Point point = new Point(dataGridView.Location.X, dataGridView.Location.Y);
            AutomationElement element = AutomationElement.FromPoint(point);
            while (element != null && element.Current.LocalizedControlType.Contains(DATA_GRID) == false)
                element = TreeWalker.RawViewWalker.GetParent(element);
            if (element != null)
            {
                GridPattern gridPattern = element.GetCurrentPattern(GridPattern.Pattern) as GridPattern;
                if (gridPattern != null)
                    return gridPattern.Current.RowCount;
            }
            return -1;
        }

        // get
        public string GetMessageBoxText(string className)
        {
            return _driver.FindElementByClassName(className).Text;
        }

        // test
        public void AssertDataGridViewRowCountNotEmpty(string id)
        {
            var dataGridView = _driver.FindElementByAccessibilityId(id);
            Point point = new Point(dataGridView.Location.X, dataGridView.Location.Y);
            AutomationElement element = AutomationElement.FromPoint(point);
            while (element != null && element.Current.LocalizedControlType.Contains(DATA_GRID) == false)
                element = TreeWalker.RawViewWalker.GetParent(element);
            if (element != null)
            {
                GridPattern gridPattern = element.GetCurrentPattern(GridPattern.Pattern) as GridPattern;
                if (gridPattern != null)
                    Assert.AreNotEqual(0, gridPattern.Current.RowCount);
            }
        }

        // test
        public void AssertEnableById(string id, bool state)
        {
            WindowsElement element = _driver.FindElementByAccessibilityId(id);
            Assert.AreEqual(state, element.Enabled);
        }

        //text
        public void TypeTextBox(string id, string text)
        {
            _driver.FindElementByAccessibilityId(id).Clear();
            _driver.FindElementByAccessibilityId(id).SendKeys(text);
        }

        // test
        public void AssertTextByName(string name, string text)
        {
            WindowsElement element = _driver.FindElementByName(name);
            Assert.AreEqual(text, element.Text);
        }

        // test
        public void ClickListBox(string name)
        {
            _driver.FindElementByName(name).Click();
        }

        // test
        public void ClickGroupBox(string name, string targetName)
        {
            _driver.FindElementByName(name).Click();
            _driver.FindElementByName(targetName).Click();
        }

        //test
        public void RollDown(int times)
        {
            for (int i = 0; i < times; i++)
                _driver.FindElementByName(NEXT_ROW).Click();
        }

        //Take
        private string[] TakeOutDataGridViewRowData(System.Collections.ObjectModel.ReadOnlyCollection<AppiumWebElement> rowDatas)
        {
            string[] data = new string[rowDatas.Count - 1];
            // FindElementsByXPath("//*") 會把 "row" node 也抓出來，因此 i 要從 1 開始以跳過 "row" node
            for (int i = 1; i < rowDatas.Count; i++)
                data[i - 1] += rowDatas[i].Text.Replace(NULL, "");
            return data;
        }

        // test
        private void SwitchWithNotContain(string formId)
        {
            foreach (var windowHandle in _driver.WindowHandles)
            {
                _driver.SwitchTo().Window(windowHandle);
                try
                {
                    _driver.FindElementByAccessibilityId(formId);
                    _windowHandles.Add(formId, windowHandle);
                    return;
                }
                catch
                {
                }
            }
        }
    }
}
