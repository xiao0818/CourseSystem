using System.Collections.Generic;

namespace CourseSystem
{
    public class CourseSelectionResultFormPresentationModel
    {
        public event PresentationModelChangedEventHandler _presentationModelChanged;
        public delegate void PresentationModelChangedEventHandler();
        PresentationModel _presentationModel;
        public CourseSelectionResultFormPresentationModel(PresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            _presentationModel._presentationModelChanged += ReloadCourseSelectionResultForm;
        }

        //GetSelectedCourseList
        public List<CourseInfo> GetSelectedCourseList
        {
            get
            {
                return _presentationModel.GetSelectedCourseList;
            }
        }

        //Remove
        public void RemoveCourseFromSelectionResult(int index)
        {
            _presentationModel.RemoveCourseFromSelectionResult(index);
        }

        //UpdataCourseSelectionResultForm
        private void ReloadCourseSelectionResultForm()
        {
            NotifyObserver();
        }

        //UpdateAllForm
        public void ReloadAllForm()
        {
            _presentationModel.ReloadAllForm();
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
