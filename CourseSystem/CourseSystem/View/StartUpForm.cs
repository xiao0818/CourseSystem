using System;
using System.Windows.Forms;

namespace CourseSystem
{
    public partial class StartUpForm : Form
    {
        Model _model;
        PresentationModel _presentationModel;
        CourseManagementFormPresentationModel _courseManagementFormPresentationModel;
        CourseSelectingFormPresentationModel _courseSelectingFormPresentationModel;
        CourseSelectionResultFormPresentationModel _courseSelectionResultFormPresentationModel;
        ImportCourseProgressFormPresentationModel _importCourseProgressFormPresentationModel;
        StartUpFormPresentationModel _startUpFormPresentationModel;
        CourseSelectingForm _courseSelectingForm;
        CourseManagementForm _courseManagementForm;
        public StartUpForm()
        {
            _model = new Model();
            _presentationModel = new PresentationModel(_model);
            _courseManagementFormPresentationModel = new CourseManagementFormPresentationModel(_presentationModel);
            _courseSelectingFormPresentationModel = new CourseSelectingFormPresentationModel(_presentationModel);
            _courseSelectionResultFormPresentationModel = new CourseSelectionResultFormPresentationModel(_presentationModel);
            _importCourseProgressFormPresentationModel = new ImportCourseProgressFormPresentationModel(_presentationModel);
            _startUpFormPresentationModel = new StartUpFormPresentationModel();
            _courseSelectingForm = new CourseSelectingForm(this, _courseSelectingFormPresentationModel, _courseSelectionResultFormPresentationModel);
            _courseManagementForm = new CourseManagementForm(this, _courseManagementFormPresentationModel, _importCourseProgressFormPresentationModel);
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

        //ClosingFormStartUpForm
        private void ClosingFormStartUpForm(object sender, FormClosingEventArgs e)
        {
            _courseSelectingForm.Close();
            _courseManagementForm.Close();
        }
    }
}
