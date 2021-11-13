using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem
{
    public class ImportCourseProgressFormPresentationModel
    {
        public event PresentationModelChangedEventHandler _presentationModelChanged;
        public delegate void PresentationModelChangedEventHandler();
        PresentationModel _presentationModel;
        public ImportCourseProgressFormPresentationModel(PresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            _presentationModel._presentationModelChanged += ReloadImportCourseProgressForm;
        }

        //ClickLoadComputerScienceCourseTabButton
        public void ClickLoadComputerScienceCourseTabButton()
        {
            
            _presentationModel.ClickLoadComputerScienceCourseTabButton();
        }

        //WaitNSeconds
        public void WaitSeconds(int second)
        {
            _presentationModel.WaitSeconds(second);
        }

        //UpdataCourseSelectionResultForm
        private void ReloadImportCourseProgressForm()
        {
            NotifyObserver();
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
