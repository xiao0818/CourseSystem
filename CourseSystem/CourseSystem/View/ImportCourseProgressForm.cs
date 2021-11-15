using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CourseSystem
{
    public partial class ImportCourseProgressForm : Form
    {
        ImportCourseProgressFormPresentationModel _importCourseProgressFormPresentationModel;
        CourseManagementForm _courseManagementForm;
        const string FRONT_CONTENT = "正在匯入課程....";
        const string PERCENT = "%";
        public ImportCourseProgressForm(ImportCourseProgressFormPresentationModel importCourseProgressFormPresentationModel, CourseManagementForm courseManagementForm)
        {
            _courseManagementForm = courseManagementForm;
            _importCourseProgressFormPresentationModel = importCourseProgressFormPresentationModel;
            _importCourseProgressFormPresentationModel._presentationModelChanged += LoadProgressBar;
            InitializeComponent();
            _progressBar.Step = 20;
            _progressBar.Minimum = 0;
        }

        //LoadProgressingBar
        private void LoadProgressBar()
        {
            _progressBar.PerformStep();
            _progressBar.Update();
            _progressLabel.Text = FRONT_CONTENT + _progressBar.Value + PERCENT;
            this.Refresh();
            if (_progressBar.Value == 100)
            {
                _importCourseProgressFormPresentationModel.WaitSeconds(1);
                this.Close();
            }
        }

        //ClosingImportCourseProgressForm
        private void ClosingImportCourseProgressForm(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.Hide();
            _importCourseProgressFormPresentationModel._presentationModelChanged -= LoadProgressBar;
            _progressBar.Value = 0;
            _progressLabel.Text = FRONT_CONTENT + _progressBar.Value + PERCENT;
            _courseManagementForm.FinishLoadComputerScienceCourse();
        }

        //ShownImportCourseProgressForm
        private void ShowImportCourseProgressForm(object sender, EventArgs e)
        {
            _importCourseProgressFormPresentationModel.WaitSeconds(1);
            _importCourseProgressFormPresentationModel.ClickLoadComputerScienceCourseTabButton();
        }

        //LoadImportCourseProgressForm
        private void LoadImportCourseProgressForm(object sender, EventArgs e)
        {
            _progressBar.Value = 0;
            _progressLabel.Text = FRONT_CONTENT + _progressBar.Value + PERCENT;
        }
    }
}
