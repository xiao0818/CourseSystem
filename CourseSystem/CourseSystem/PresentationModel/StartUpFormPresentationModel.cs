using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    public class StartUpFormPresentationModel
    {
        bool _isCourseSelectingFormButtonEnabled;
        bool _isCourseManagementFormButtonEnabled;

        public StartUpFormPresentationModel()
        {
            _isCourseSelectingFormButtonEnabled = true;
            _isCourseManagementFormButtonEnabled = true;
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
