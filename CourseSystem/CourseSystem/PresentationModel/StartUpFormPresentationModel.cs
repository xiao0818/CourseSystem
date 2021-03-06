namespace CourseSystem
{
    public class StartUpFormPresentationModel
    {
        bool _isCourseSelectingFormButtonEnabled = true;
        bool _isCourseManagementFormButtonEnabled = true;

        public StartUpFormPresentationModel()
        {
        }

        //IsCourseSelectionButtonEnabled
        public bool IsCourseSelectingFormButtonEnabled
        {
            get
            {
                return _isCourseSelectingFormButtonEnabled;
            }
        }

        //IsCourseManagementButtonEnabled
        public bool IsCourseManagementFormButtonEnabled
        {
            get
            {
                return _isCourseManagementFormButtonEnabled;
            }
        }

        //ClickCourseSelectingFormButton
        public void ClickCourseSelectingFormButton()
        {
            _isCourseSelectingFormButtonEnabled = false;
        }

        //ClickCourseManagementFormButton
        public void ClickCourseManagementFormButton()
        {
            _isCourseManagementFormButtonEnabled = false;
        }

        //ResetCourseSelectingFormButton
        public void ResetCourseSelectingFormButton()
        {
            _isCourseSelectingFormButtonEnabled = true;
        }

        //ResetCourseManagementFormButton
        public void ResetCourseManagementFormButton()
        {
            _isCourseManagementFormButtonEnabled = true;
        }
    }
}
