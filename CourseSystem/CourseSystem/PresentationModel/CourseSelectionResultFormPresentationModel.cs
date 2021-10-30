using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem
{
    public class CourseSelectionResultFormPresentationModel
    {
        public event PresentationModelChangedEventHandler _presentationModelChanged;
        public delegate void PresentationModelChangedEventHandler();
        Model _model;
        public CourseSelectionResultFormPresentationModel(Model model)
        {
            _model = model;
            _model._modelChanged += ReloadCourseSelectionResultForm;
        }

        //GetResultDataGridViewRowList
        public List<DataGridViewRow> GetResultDataGridViewRowList()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            List<CourseInfo> courseList = _model.GetSelectedCourseList;
            foreach (CourseInfo course in courseList)
            {
                DataGridViewRow row = GetRowFromInfo(course);
                rows.Add(row);
            }
            return rows;
        }

        //GetRowFromInfo
        private DataGridViewRow GetRowFromInfo(CourseInfo course)
        {
            const string TEXT_OF_BUTTON = "退選";
            DataGridViewRow row = new DataGridViewRow();
            foreach (string info in course.GetCourseInfoString)
            {
                row.Cells.Add(new DataGridViewTextBoxCell
                {
                    Value = info
                });
            };
            row.Cells.Insert(0, new DataGridViewButtonCell
            {
                Value = TEXT_OF_BUTTON
            });
            return row;
        }

        //Remove
        public void RemoveCourseFromSelectionResult(int index)
        {
            _model.RemoveCourseFromSelectionResult(index);
        }

        //UpdataCourseSelectionResultForm
        public void ReloadCourseSelectionResultForm()
        {
            NotifyObserver();
        }

        //UpdateAllForm
        public void ReloadAllForm()
        {
            _model.ReloadAllForm();
        }

        //NotifyObservers
        public void NotifyObserver()
        {
            if (_presentationModelChanged != null)
            {
                _presentationModelChanged();
            }
        }
    }
}
