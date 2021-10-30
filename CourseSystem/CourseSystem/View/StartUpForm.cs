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
    public partial class StartUpForm : Form
    {
        Model _model;
        CourseManagementFormPresentationModel _courseManagementFormPresentationModel;
        CourseSelectingFormPresentationModel _courseSelectingFormPresentationModel;
        CourseSelectionResultFormPresentationModel _courseSelectionResultFormPresentationModel;
        StartUpFormPresentationModel _startUpFormPresentationModel;
        CourseSelectingForm _courseSelectingForm;
        CourseManagementForm _courseManagementForm;
        public StartUpForm()
        {
            _model = new Model();
            _courseManagementFormPresentationModel = new CourseManagementFormPresentationModel(_model);
            _courseSelectingFormPresentationModel = new CourseSelectingFormPresentationModel(_model);
            _courseSelectionResultFormPresentationModel = new CourseSelectionResultFormPresentationModel(_model);
            _startUpFormPresentationModel = new StartUpFormPresentationModel();
            _courseSelectingForm = new CourseSelectingForm(this, _courseSelectingFormPresentationModel, _courseSelectionResultFormPresentationModel);
            _courseManagementForm = new CourseManagementForm(this, _courseManagementFormPresentationModel);
            InitializeComponent();
        }

        //ClickCourseSelectingSystemButton
        private void ClickCourseSelectingButton(object sender, EventArgs e)
        {
            _startUpFormPresentationModel.ClickCourseSelectingFormButton();
            _courseSelectingFormButton.Enabled = _startUpFormPresentationModel.IsCourseSelectingFormButtonEnabled;
            _courseSelectingForm.Show();
        }

        //ClickCourseSelectionResultFormButton
        private void ClickCourseManagementFormButton(object sender, EventArgs e)
        {
            _startUpFormPresentationModel.ClickCourseManagementFormButton();
            _courseManagementFormButton.Enabled = _startUpFormPresentationModel.IsCourseManagementFormButtonEnabled;
            _courseManagementForm.Show();
        }

        //ClickExitButton
        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
        }

        //ResetCourseSelectingFormButton
        public void ResetCourseSelectingFormButton()
        {
            _startUpFormPresentationModel.ResetCourseSelectingFormButton();
            _courseSelectingFormButton.Enabled = _startUpFormPresentationModel.IsCourseSelectingFormButtonEnabled;
        }

        //ResetCourseManagementFormButton
        public void ResetCourseManagementFormButton()
        {
            _startUpFormPresentationModel.ResetCourseManagementFormButton();
            _courseManagementFormButton.Enabled = _startUpFormPresentationModel.IsCourseManagementFormButtonEnabled;
        }
    }
}
