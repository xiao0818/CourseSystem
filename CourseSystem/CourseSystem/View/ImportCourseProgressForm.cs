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
    public partial class ImportCourseProgressForm : Form
    {
        ImportCourseProgressFormPresentationModel _importCourseProgressFormPresentationModel;
        //CourseManagementForm _courseManagementForm;
        public ImportCourseProgressForm(ImportCourseProgressFormPresentationModel importCourseProgressFormPresentationModel, CourseManagementForm courseManagementForm)
        {
            //_courseManagementForm = courseManagementForm;
            _importCourseProgressFormPresentationModel = importCourseProgressFormPresentationModel;
            _importCourseProgressFormPresentationModel._presentationModelChanged += LoadProgressBar;
            InitializeComponent();
        }

        //LoadProgressingBar
        public void LoadProgressBar()
        {
            int progress = _importCourseProgressFormPresentationModel.GetImportCourseProgerss();
            _progressBar.Value = progress;
            _progressLabel.Text = "正在匯入課程...." + progress.ToString() + "%";

            if (progress == 100)
            {
                this.Close();
            }
        }

        //ClosingImportCourseProgressForm
        private void ClosingImportCourseProgressForm(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            _progressBar.Value = 0;
            _progressLabel.Text = "正在匯入課程....0%";
        }
    }
}
