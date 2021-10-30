using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSystem
{
    public partial class CourseSelectionResultForm : Form
    {
        CourseSelectionResultFormPresentationModel _courseSelectionResultFormPresentationModel;
        CourseSelectingForm _courseSelectingForm;
        public CourseSelectionResultForm(CourseSelectingForm courseSelectingForm, CourseSelectionResultFormPresentationModel courseSelectionResultFormPresentationModel)
        {
            _courseSelectionResultFormPresentationModel = courseSelectionResultFormPresentationModel;
            _courseSelectingForm = courseSelectingForm;
            _courseSelectionResultFormPresentationModel._presentationModelChanged += LoadCourseResultDataGridView;
            InitializeComponent();
        }

        //LoadCourseSelectionResultForm
        private void LoadCourseSelectionResultForm(object sender, EventArgs e)
        {
            LoadCourseResultDataGridView();
        }

        //LoadCourseResultDataGridView
        public void LoadCourseResultDataGridView()
        {
            _courseResultDataGridView.Rows.Clear();
            List<DataGridViewRow> rows = _courseSelectionResultFormPresentationModel.GetResultDataGridViewRowList();
            foreach (DataGridViewRow row in rows)
            {
                _courseResultDataGridView.Rows.Add(row);
            }
        }

        //ClickCellContentCourseResultDataGridView
        private void ClickCellContentCourseResultDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                _courseSelectionResultFormPresentationModel.RemoveCourseFromSelectionResult(e.RowIndex);
            }
            UpdateAllForm();
        }

        //ClosingFormCourseSelectionResultForm
        private void ClosingFormCourseSelectionResultForm(object sender, FormClosingEventArgs e)
        {
            _courseSelectingForm.ResetCheckButton();
            e.Cancel = true;
            Hide();
        }

        //UpdateAllForm
        public void UpdateAllForm()
        {
            _courseSelectionResultFormPresentationModel.ReloadAllForm();
        }
    }
}
