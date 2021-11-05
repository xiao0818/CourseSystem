using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CourseSystem
{
    public class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        const string WEB_COMPUTER_SCIENCE_3 = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
        const string WEB_ELECTRONIC_ENGINEERING_3_A = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2423";
        private List<CourseInfo> _selectedCourseList;
        private Dictionary<string, int> _courseTabDictionary;
        const string STRUCTURE = "//body/table";
        private Dictionary<int, List<CourseInfo>> _courseListDictionary;
        public Model()
        {
            _modelChanged += SortAll;
            _courseListDictionary = new Dictionary<int, List<CourseInfo>>();
            _courseListDictionary.Add((int)Department.ComputerScience3, GetCourseInfo(WEB_COMPUTER_SCIENCE_3)) ;
            _courseListDictionary.Add((int)Department.ElectronicEngineering3, GetCourseInfo(WEB_ELECTRONIC_ENGINEERING_3_A)) ;
            _selectedCourseList = new List<CourseInfo>();
            SortAll();
            _courseTabDictionary = new Dictionary<string, int>();
        }

        //爬蟲網頁資料
        private List<CourseInfo> GetCourseInfo(string web)
        {
            HtmlNodeCollection nodeTableRow = GetFirst(web);
            List<CourseInfo> courseInfo = new List<CourseInfo>();

            foreach (var node in nodeTableRow)
            {
                HtmlNodeCollection nodeTableDatas = node.ChildNodes;
                // 移除 #text
                nodeTableDatas.RemoveAt(0);
                courseInfo.Add(GetNewCourseInfo(nodeTableDatas));
            }
            return courseInfo;
        }

        //GetFirstPart
        private HtmlNodeCollection GetFirst(string web)
        {
            HtmlWeb webClient = new HtmlWeb();
            webClient.OverrideEncoding = Encoding.Default;
            HtmlDocument document = webClient.Load(web);

            HtmlNode nodeTable = document.DocumentNode.SelectSingleNode(STRUCTURE);
            HtmlNodeCollection nodeTableRow = nodeTable.ChildNodes;

            // 移除 tbody
            nodeTableRow.RemoveAt(0);
            // 移除 <tr>資工三
            nodeTableRow.RemoveAt(0);
            // 移除 table header
            nodeTableRow.RemoveAt(0);
            // 移除 <tr>小計
            nodeTableRow.RemoveAt(GetCount(nodeTableRow));
            return nodeTableRow;
        }

        //GetCount
        private int GetCount(HtmlNodeCollection nodeTableRow)
        {
            return nodeTableRow.Count - 1;
        }

        //GetNewCourseInfo
        private CourseInfo GetNewCourseInfo(HtmlNodeCollection nodeTableDatas)
        {
            return new CourseInfo(
                        nodeTableDatas[(int)CourseInfoHeaderText.Number].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Name].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Stage].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Credit].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Hour].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.CourseType].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Teacher].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.ClassTime0].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime1].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime2].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime3].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime4].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime5].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.ClassTime6].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Classroom].InnerText.Trim(),
                        nodeTableDatas[(int)CourseInfoHeaderText.NumberOfStudent].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.NumberOfDropStudent].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.TeachingAssistant].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Language].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Outline].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Note].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.AttachStudent].InnerText.Trim(), nodeTableDatas[(int)CourseInfoHeaderText.Experiment].InnerText.Trim());
        }

        //Get
        public List<CourseInfo> GetComputerScience3CourseList
        {
            get
            {
                return _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value;
            }
        }

        //Get
        public List<CourseInfo> GetElectronicEngineering3CourseList
        {
            get
            {
                return _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value;
            }
        }

        //Get
        public List<CourseInfo> GetSelectedCourseList
        {
            get
            {
                return _selectedCourseList;
            }
        }

        //remove
        public void RemoveFromCourseList(int index, int rowIndex)
        {
            _courseTabDictionary.Add(_courseListDictionary.ElementAt(index).Value[rowIndex].Number, index);
            _courseListDictionary.ElementAt(index).Value.RemoveAt(rowIndex);
        }

        //remove
        public void RemoveCourseFromComputerScience3(int index)
        {
            _courseTabDictionary.Add(_courseListDictionary.ElementAt((int)Department.ComputerScience3).Value[index].Number, (int)Department.ComputerScience3);
            _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.RemoveAt(index);
        }

        //remove
        public void RemoveCourseFromElectronicEngineering3(int index)
        {
            _courseTabDictionary.Add(_courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value[index].Number, (int)Department.ElectronicEngineering3);
            _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value.RemoveAt(index);
        }

        //remove
        public void RemoveCourseFromSelectionResult(int index)
        {
            if (_courseTabDictionary[_selectedCourseList[index].Number] == (int)Department.ComputerScience3)
            {
                _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Add(_selectedCourseList[index]);
            }
            if (_courseTabDictionary[_selectedCourseList[index].Number] == (int)Department.ElectronicEngineering3)
            {
                _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value.Add(_selectedCourseList[index]);
            }
            _courseTabDictionary.Remove(_selectedCourseList[index].Number);
            _selectedCourseList.RemoveAt(index);
        }

        //GetNumber
        private string GetNumber(CourseInfo courseInfo)
        {
            return courseInfo.Number;
        }

        //sort
        private void SortAll()
        {
            _selectedCourseList.Sort(delegate (CourseInfo x, CourseInfo y)
            {
                return x.Number.CompareTo(GetNumber(y));
            });
            _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Sort(delegate (CourseInfo x, CourseInfo y)
            {
                return x.Number.CompareTo(GetNumber(y));
            });
            _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value.Sort(delegate (CourseInfo x, CourseInfo y)
            {
                return x.Number.CompareTo(GetNumber(y));
            });
        }

        //GetCourseInfoBySelectedIndex(_courseListBox.SelectedIndex)
        public CourseInfo GetCourseInfoBySelectedIndex(int selectedIndex)
        {
            if (selectedIndex < _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Count)
            {
                return _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value[selectedIndex];
            }
            else if (selectedIndex - _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Count < _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value.Count)
            {
                return _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value[selectedIndex - _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Count];
            }
            else
            {
                return _selectedCourseList[selectedIndex - _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Count - _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value.Count];
            }
        }

        //GetCourseDepartmentBySelectedIndex(_courseListBox.SelectedIndex)
        public Tuple<int, int, int> GetCourseDepartmentBySelectedIndex(int selectedIndex)
        {
            if (selectedIndex < _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Count)
            {
                return Tuple.Create((int)ListName.ComputerScience3, (int)Department.ComputerScience3, selectedIndex);
            }
            else if (selectedIndex - _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Count < _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value.Count)
            {
                return Tuple.Create((int)ListName.ElectronicEngineering3, (int)Department.ElectronicEngineering3, selectedIndex - _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Count);
            }
            else
            {
                return Tuple.Create((int)ListName.SelectedList, _courseTabDictionary[_selectedCourseList[selectedIndex - _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Count - _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value.Count].Number], selectedIndex - _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Count - _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value.Count);
            }
        }

        //AddIntoSelectedCourseList
        public void AddIntoSelectedCourseList(CourseInfo course, int department)
        {
            _selectedCourseList.Add(course);
            _courseTabDictionary.Add(course.Number, department);
        }

        //AddIntoComputerScience3CourseList
        public void AddIntoComputerScience3CourseList(CourseInfo course)
        {
            _courseListDictionary.ElementAt((int)Department.ComputerScience3).Value.Add(course);
        }

        //AddIntoElectronicEngineering3CourseList
        public void AddIntoElectronicEngineering3CourseList(CourseInfo course)
        {
            _courseListDictionary.ElementAt((int)Department.ElectronicEngineering3).Value.Add(course);
        }

        //RemoveCourseFromTabDictionary
        public void RemoveCourseFromTabDictionary(int index)
        {
            _courseTabDictionary.Remove(_selectedCourseList[index].Number);
        }

        //AddSelectedCourse
        public void AddSelectedCourse(CourseInfo selectingCourse)
        {
            _selectedCourseList.Add(selectingCourse);
        }

        //UpdateAllForm
        public void ReloadAllForm()
        {
            NotifyObserver();
        }

        //NotifyObservers
        public void NotifyObserver()
        {
            if (_modelChanged != null)
            {
                _modelChanged();
            }
        }
    }
}
