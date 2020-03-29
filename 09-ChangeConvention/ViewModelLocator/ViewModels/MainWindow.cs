using Prism.Mvvm;

namespace ViewModelLocator.ViewModels
{
    public class MainWindow : BindableBase
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindow()
        {

        }
    }
}
